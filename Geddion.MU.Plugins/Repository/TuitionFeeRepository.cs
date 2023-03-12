using System;
using System.Collections.Generic;
using System.Linq;
using Geddion.MU.Plugins.Model;
using Geddion.MU.Plugins.Model.Enum;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

namespace Geddion.MU.Plugins.Repository
{
	/// <summary>
	/// Tuition Fee Repository
	/// </summary>
	public class TuitionFeeRepository
	{
		private readonly IOrganizationService _service;

		/// <summary>
		/// TuitionFeeRepository
		/// </summary>
		/// <param name="service">Crm service</param>
		public TuitionFeeRepository(IOrganizationService service)
		{
			_service = service;
		}

		/// <summary>
		/// Get Tuition Fees
		/// </summary>
		/// <param name="studyPlan">Study plan id</param>
		/// <param name="year">Year</param>
		/// <param name="local">Local</param>
		/// <param name="fullTime">Full time</param>
		/// <param name="attributes">Entity attributes</param>
		/// <returns></returns>
		public IEnumerable<TuitionFee> GetTuitionFees(Guid studyPlan, string year, int local, int fullTime, params string[] attributes)
		{
			var query = new QueryExpression(TuitionFee.EntityLogicalName)
			{
				ColumnSet = new ColumnSet(attributes)
			};

			query.Criteria.AddCondition(TuitionFee.Fields.StudyPlan, ConditionOperator.Equal, studyPlan); 
			query.Criteria.AddCondition(TuitionFee.Fields.YearOfEnrolment, ConditionOperator.Equal, year); 
			query.Criteria.AddCondition(TuitionFee.Fields.LocalInternational, ConditionOperator.Equal, local); 
			query.Criteria.AddCondition(TuitionFee.Fields.FullTimePartTime, ConditionOperator.Equal, fullTime);
			query.Criteria.AddCondition(TuitionFee.Fields.StateCode, ConditionOperator.Equal, (int)CustomEntityStateCode.Active);

			return _service.RetrieveMultiple(query).Entities.Select(entity => entity.ToEntity<TuitionFee>());
		}

		/// <summary>
		/// Get Tuition fee
		/// </summary>
		/// <param name="tuitionId">Tuition fee Id</param>
		/// <param name="attributes">>Entity attributes</param>
		/// <returns></returns>
		public TuitionFee Get(Guid tuitionId, params string[] attributes)
		{
			return _service.Retrieve(TuitionFee.EntityLogicalName, tuitionId, new ColumnSet(attributes))
				.ToEntity<TuitionFee>();
		}
	}
}