using Geddion.MU.Plugins.Model;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Geddion.MU.Plugins {

	/// <summary>
	/// Copy Modules
	/// </summary>
	public class CopyModules : IPlugin {
		/// <summary>Request the plug-in to Execute business logic.</summary>
		/// <param name="serviceProvider">Interface to the Service Provider.</param>
		public void Execute(IServiceProvider serviceProvider) {
			var context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
			var serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
			var service = serviceFactory.CreateOrganizationService(null);
			var entity = ((Entity)context.InputParameters["Target"]).ToEntity<StudyPlan>();
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

			if (entity.StudyProgram is not null) {

				var mdxModules = GetModulesByProgram(entity.StudyProgram.Id, service,
					MdxModule.Fields.GroupCode,
					MdxModule.Fields.ModuleCode,
					MdxModule.Fields.ModTitle,
					MdxModule.Fields.Requirement,
					MdxModule.Fields.OptionBlock,
					MdxModule.Fields.StudyMode,
					MdxModule.Fields.ModMaxCredits,
					MdxModule.Fields.ModuleLengthWeeks);


				foreach (var mdxModule in mdxModules) {
					var studyModule = new StudyModule {
						Mdxmodule = mdxModule.ToEntityReference(),
						ProgramCode = entity.StudyProgram,
						StudyPlan = entity.ToEntityReference(),
						GroupCode = mdxModule.GroupCode,
						ModuleCode = mdxModule.ModuleCode,
						Requirement = mdxModule.Requirement,
						OptionBlock = mdxModule.OptionBlock,
						StudyMode = mdxModule.StudyMode,
						ModMaxCredits = mdxModule.ModMaxCredits,
						ModuleLengthWeeks = mdxModule.ModuleLengthWeeks
					};
					service.Create(studyModule);
				}
			}
			else {
				var myModules = GetMyModules(entity.Id, service);
				foreach (var myModule in myModules) {
					service.Delete(StudyModule.EntityLogicalName, myModule.Id);
				}
			}

		}

		private static IEnumerable<MdxModule> GetModulesByProgram(Guid studyProgramId, IOrganizationService service, params string[] attributes) {
			var query = new QueryExpression(MdxModule.EntityLogicalName) { ColumnSet = new ColumnSet(attributes) };

			var developmentPhaseNnLink =
				query.AddLink(NnRelationships.ProgramModuleNn, MdxModule.Fields.Id, MdxModule.Fields.Id);
			developmentPhaseNnLink.LinkCriteria.AddCondition(Program.Fields.Id, ConditionOperator.Equal,
				studyProgramId);

			return service.RetrieveMultiple(query).Entities.Select(entity => entity.ToEntity<MdxModule>());
		}

		private static IEnumerable<StudyModule> GetMyModules(Guid studyPlanId, IOrganizationService service, params string[] attributes) {
			var query = new QueryExpression(StudyModule.EntityLogicalName) { ColumnSet = new ColumnSet(attributes) };
			query.Criteria.AddCondition(StudyModule.Fields.StudyPlan, ConditionOperator.Equal, studyPlanId);

			return service.RetrieveMultiple(query).Entities.Select(entity => entity.ToEntity<StudyModule>());
		}
	}
}
