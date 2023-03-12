using Geddion.MU.Plugins.Model;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System.Collections.Generic;
using System.Linq;

namespace Geddion.MU.Plugins.Repository {

	/// <summary>
	/// Study Plan Repository
	/// </summary>
	public class StudyPlanRepository {
		private readonly IOrganizationService _service;

		/// <summary>
		/// Study Plan Repository
		/// </summary>
		/// <param name="service">Crm service</param>
		public StudyPlanRepository(IOrganizationService service) {
			_service = service;
		}

		/// <summary>
		/// Get Active Study Plans
		/// </summary>
		/// <param name="attributes">Entity attributes</param>
		/// <returns></returns>
		public IEnumerable<StudyPlan> GetActiveStudyPlans(params string[] attributes) {
			var query = new QueryExpression(StudyPlan.EntityLogicalName) {
				ColumnSet = new ColumnSet(attributes)
			};
			query.Criteria.AddCondition(StudyPlan.Fields.PlanStatus, ConditionOperator.Equal, 899290000); //active

			return _service.RetrieveMultiple(query).Entities.Select(entity => entity.ToEntity<StudyPlan>());
		}
	}
}
