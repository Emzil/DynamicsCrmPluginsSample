using Geddion.MU.Plugins.Service;
using Microsoft.Xrm.Sdk;
using System;

namespace Geddion.MU.Plugins {

	/// <summary>
	/// Calculate Tuition Fee Plugin
	/// </summary>
	public class CalcTuitionFee : IPlugin {
		/// <summary>Request the plug-in to Execute business logic.</summary>
		/// <param name="serviceProvider">Interface to the Service Provider.</param>
		public void Execute(IServiceProvider serviceProvider) {
			var serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
			var service = serviceFactory.CreateOrganizationService(null);

			var tuitionFeeService = new TuitionFeeService(service);
			tuitionFeeService.CalculateTuitionFee();

		}
	}
}
