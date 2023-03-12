using System;
using System.Collections.Generic;
using System.Linq;
using Geddion.MU.Plugins.Model;
using Geddion.MU.Plugins.Model.Enum;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

namespace Geddion.MU.Plugins.Repository;

/// <summary>
/// Invoice Repository
/// </summary>
public class InvoiceRepository
{
	private readonly IOrganizationService _service;

	/// <summary>
	/// Invoice Repository
	/// </summary>
	/// <param name="service">Crm service</param>
	public InvoiceRepository(IOrganizationService service)
	{
		_service = service;
	}

	/// <summary>
	/// Get Invoices
	/// </summary>
	/// <param name="tuitionFeeId">Tuition Fee Id</param>
	/// <param name="attributes">Entity attributes</param>
	/// <returns></returns>
	public IEnumerable<Invoice> GetInvoices(Guid tuitionFeeId, params string[] attributes)
	{
		var query = new QueryExpression(Invoice.EntityLogicalName)
		{
			ColumnSet = new ColumnSet(attributes)
		};

		query.Criteria.AddCondition(Invoice.Fields.TuitionFee, ConditionOperator.Equal, tuitionFeeId); 
		query.Criteria.AddCondition(Invoice.Fields.StateCode, ConditionOperator.Equal, (int)CustomEntityStateCode.Active);

		return _service.RetrieveMultiple(query).Entities.Select(entity => entity.ToEntity<Invoice>());
	}
}