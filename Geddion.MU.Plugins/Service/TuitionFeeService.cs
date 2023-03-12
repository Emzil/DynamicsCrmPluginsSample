using Geddion.MU.Plugins.Model;
using Geddion.MU.Plugins.Model.Enum;
using Geddion.MU.Plugins.Repository;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using System.Collections.Generic;
using System.Linq;

namespace Geddion.MU.Plugins.Service {
	/// <summary>
	/// Tuition Fee Service
	/// </summary>
	public class TuitionFeeService {
		private readonly IOrganizationService _service;

		/// <summary>
		/// Tuition Fee Service
		/// </summary>
		/// <param name="service">Crm service</param>
		public TuitionFeeService(IOrganizationService service) {
			_service = service;
		}

		/// <summary>
		/// Calculate Tuition Fee
		/// </summary>
		public void CalculateTuitionFee() {
			var studyPlanRepository = new StudyPlanRepository(_service);
			var tuitionFeeRepository = new TuitionFeeRepository(_service);
			var programFeeDatabaseRepository = new ProgramFeeDatabaseRepository(_service);
			var invoiceRepository = new InvoiceRepository(_service);
			var programRepository = new ProgramRepository(_service);

			var studyPlans = studyPlanRepository.GetActiveStudyPlans(
				StudyPlan.Fields.YearOfEnrolment,
				StudyPlan.Fields.FullTimePartTime,
				StudyPlan.Fields.LocalInternational,
				StudyPlan.Fields.AdmissionType,
				StudyPlan.Fields.Category,
				StudyPlan.Fields.Program,
				StudyPlan.Fields.NewExistingStudent,
				StudyPlan.Fields.PaymentSchedule,
				StudyPlan.Fields.NumberActiveModuleCredits
			);

			foreach (var studyPlan in studyPlans) {
				if (studyPlan.LocalInternational is null
					|| studyPlan.FullTimePartTime is null
					|| string.IsNullOrEmpty(studyPlan.YearOfEnrolment)
					|| studyPlan.AdmissionType is null
					|| studyPlan.Category is null)
					continue;

				var category = studyPlan.FormattedValues[StudyPlan.Fields.Category];

				var programFeeDatabases = programFeeDatabaseRepository.GetProgramFeeDatabase(studyPlan.YearOfEnrolment,
					studyPlan.LocalInternational.Value, studyPlan.FullTimePartTime.Value,
					studyPlan.AdmissionType.Value,
					category,
					ProgramFeeDatabase.Fields.FullPayment,
					ProgramFeeDatabase.Fields.Deposit,
					ProgramFeeDatabase.Fields.Instalments_1,
					ProgramFeeDatabase.Fields.Instalments_2,
					ProgramFeeDatabase.Fields.Instalments_3,
					ProgramFeeDatabase.Fields.YearOfEnrolment,
					ProgramFeeDatabase.Fields.LocalInternational,
					ProgramFeeDatabase.Fields.FullPayment
					).ToList();

				if (!programFeeDatabases.Any())
					continue;

				var programFeeDatabase = programFeeDatabases.First();
				var tuitionFee = new TuitionFee();

				DeactivateChain(tuitionFeeRepository, studyPlan, invoiceRepository);

				switch (studyPlan.PaymentSchedule?.Value) {
					case 899290000:
						tuitionFee.TuitionFeeCredit = programFeeDatabase.FullPayment;
						break;
					case 899290001:
						tuitionFee.Deposit = programFeeDatabase.Deposit;
						tuitionFee.Instalments_1 = programFeeDatabase.Instalments_1;
						tuitionFee.Instalments_2 = programFeeDatabase.Instalments_2;
						tuitionFee.Instalments_3 = programFeeDatabase.Instalments_3;
						break;
				}

				tuitionFee.TransactionCurrencyId = programFeeDatabase.TransactionCurrencyId;
				tuitionFee.StudyPlan = studyPlan.ToEntityReference();
				tuitionFee.YearOfEnrolment = studyPlan.YearOfEnrolment;
				tuitionFee.FullTimePartTime = studyPlan.FullTimePartTime;
				tuitionFee.LocalInternational = studyPlan.LocalInternational;
				tuitionFee.StdProgramFee = programFeeDatabase.ToEntityReference();
				tuitionFee.Program = studyPlan.Program;
				tuitionFee.NewExistingStudent = studyPlan.NewExistingStudent;
				tuitionFee.PaymentSchedule = studyPlan.PaymentSchedule;
				tuitionFee.NumberActiveModuleCredits = studyPlan.NumberActiveModuleCredits;

				var tuitionFeeId = _service.Create(tuitionFee);

				var invoice = new Invoice {
					Program = studyPlan.Program,
					Student = studyPlan.Student,
					StudyPlan = studyPlan.ToEntityReference(),
					TuitionFee = new EntityReference(TuitionFee.EntityLogicalName, tuitionFeeId),
					TransactionCurrencyId = tuitionFee.TransactionCurrencyId
				};

				var invoiceId = _service.Create(invoice);

				var lineItem = new LineItem {
					InvoiceId = new EntityReference(Invoice.EntityLogicalName, invoiceId),
					TransactionCurrencyId = tuitionFee.TransactionCurrencyId,
					Amount = tuitionFeeRepository.Get(tuitionFeeId, TuitionFee.Fields.TotalAmount).TotalAmount,
					Description = studyPlan.Program is not null ? programRepository.Get(studyPlan.Program.Id, Program.Fields.ProgramTitle).ProgramTitle : "Tuition Fees"
				};

				_service.Create(lineItem);
			}
		}

		private void DeactivateChain(TuitionFeeRepository tuitionFeeRepository, StudyPlan studyPlan,
			InvoiceRepository invoiceRepository) {
			var existingTuitionFees = tuitionFeeRepository.GetTuitionFees(studyPlan.Id,
				studyPlan.YearOfEnrolment, studyPlan.LocalInternational.Value, studyPlan.FullTimePartTime.Value).ToList();

			DeactivateEntities(existingTuitionFees);

			foreach (var existingTuitionFee in existingTuitionFees) {
				DeactivateEntities(invoiceRepository.GetInvoices(existingTuitionFee.Id).ToList());
			}
		}

		private void DeactivateEntities<T>(List<T> listOfEntities) where T : Entity {
			if (!listOfEntities.Any())
				return;

			foreach (var entity in listOfEntities) {
				_service.Execute(new SetStateRequest {
					EntityMoniker = new EntityReference(entity.LogicalName, entity.Id),
					State = new OptionSetValue((int)CustomEntityStateCode.Inactive),
					Status = new OptionSetValue(-1)
				});
			}
		}
	}
}
