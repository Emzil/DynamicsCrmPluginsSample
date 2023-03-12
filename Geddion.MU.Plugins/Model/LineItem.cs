using System;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace Geddion.MU.Plugins.Model;

/// <summary>
/// LineItem entity
/// </summary>
[DataContract]
[EntityLogicalName(EntityLogicalName)]
public class LineItem : Entity
{
	/// <summary>
	/// Schema name
	/// </summary>
	public const string EntityLogicalName = "gd_lineitem";
	/// <summary>
	/// LineItem
	/// </summary>
	public LineItem() : base(EntityLogicalName)
	{

	}
	/// <summary>
	/// LineItem
	/// </summary>
	/// <param name="id"></param>
	public LineItem(Guid id) : base(EntityLogicalName, id)
	{
	}

	/// <summary>
	/// Description
	/// </summary>
	public string Description
	{
		get => GetAttributeValue<string>(Fields.Description);
		set => SetAttributeValue(Fields.Description, value);
	}

	/// <summary>
	/// Amount
	/// </summary>
	public Money Amount
	{
		get => GetAttributeValue<Money>(Fields.Amount);
		set => SetAttributeValue(Fields.Amount, value);
	}

	/// <summary>
	/// TransactionCurrencyId
	/// </summary>
	public EntityReference TransactionCurrencyId
	{
		get => GetAttributeValue<EntityReference>(Fields.TransactionCurrencyId);
		set => SetAttributeValue(Fields.TransactionCurrencyId, value);
	}

	/// <summary>
	/// InvoiceId
	/// </summary>
	public EntityReference InvoiceId
	{
		get => GetAttributeValue<EntityReference>(Fields.InvoiceId);
		set => SetAttributeValue(Fields.InvoiceId, value);
	}
	

	/// <summary>
	/// Schema
	/// </summary>
	public struct Fields
	{
		/// <summary>
		/// Id
		/// </summary>
		public const string Id = "gd_invoiceid";

		/// <summary>
		/// Description
		/// </summary>
		public const string Description = "gd_description";

		/// <summary>
		/// Amount
		/// </summary>
		public const string Amount = "gd_amount";

		/// <summary>
		/// TransactionCurrencyId
		/// </summary>
		public const string TransactionCurrencyId = "transactioncurrencyid";

		/// <summary>
		/// InvoiceId
		/// </summary>
		public const string InvoiceId = "gd_invoicelineitemid";
	}
}