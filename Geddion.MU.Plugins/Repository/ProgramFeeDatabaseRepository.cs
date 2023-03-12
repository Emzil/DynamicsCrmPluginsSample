using Geddion.MU.Plugins.Model;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System.Collections.Generic;
using System.Linq;

namespace Geddion.MU.Plugins.Repository {

	/// <summary>
	/// Tuition Fee Repository
	/// </summary>
	public class ProgramFeeDatabaseRepository {
		private readonly IOrganizationService _service;

		/// <summary>
		/// Tuition Fee Repository
		/// </summary>
		/// <param name="service">Crm service</param>
		public ProgramFeeDatabaseRepository(IOrganizationService service) {
			_service = service;
		}

		/// <summary>
		/// GetTuitionFees
		/// </summary>
		/// <param name="year">Year</param>
		/// <param name="local">Local</param>
		/// <param name="fullTime">Full time</param>
		/// <param name="admissionType">Admission type</param>
		/// <param name="category">Category</param>
		/// <param name="attributes">Entity attributes</param>
		/// <returns></returns>
		public IEnumerable<ProgramFeeDatabase> GetProgramFeeDatabase(string year, int local, int fullTime, int admissionType, string category, params string[] attributes) {
			var query = new QueryExpression(ProgramFeeDatabase.EntityLogicalName) {
				ColumnSet = new ColumnSet(attributes)
			};

			query.Criteria.AddCondition(ProgramFeeDatabase.Fields.YearOfEnrolment, ConditionOperator.Equal, year);
			query.Criteria.AddCondition(ProgramFeeDatabase.Fields.LocalInternational, ConditionOperator.Equal, local);
			query.Criteria.AddCondition(ProgramFeeDatabase.Fields.FullTimePartTime, ConditionOperator.Equal, fullTime);
			query.Criteria.AddCondition(ProgramFeeDatabase.Fields.AdmissionType, ConditionOperator.Equal, admissionType);
			query.Criteria.AddCondition(ProgramFeeDatabase.Fields.ProgramName, ConditionOperator.Equal, category);

			return _service.RetrieveMultiple(query).Entities.Select(entity => entity.ToEntity<ProgramFeeDatabase>());
		}
	}
}