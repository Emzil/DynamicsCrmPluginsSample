using System;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace Geddion.MU.Plugins.Model;

/// <summary>
/// Invoice entity
/// </summary>
[DataContract]
[EntityLogicalName(EntityLogicalName)]
public class Invoice : Entity
{
	/// <summary>
	/// Schema name
	/// </summary>
	public const string EntityLogicalName = "gd_invoice";
	/// <summary>
	/// Invoice
	/// </summary>
	public Invoice() : base(EntityLogicalName)
	{

	}
	/// <summary>
	/// Invoice
	/// </summary>
	/// <param name="id"></param>
	public Invoice(Guid id) : base(EntityLogicalName, id)
	{
	}

	/// <summary>
	/// Student
	/// </summary>
	public EntityReference Student
	{
		get => GetAttributeValue<EntityReference>(Fields.Student);
		set => SetAttributeValue(Fields.Student, value);
	}

	/// <summary>
	/// StudyPlan
	/// </summary>
	public EntityReference StudyPlan
	{
		get => GetAttributeValue<EntityReference>(Fields.StudyPlan);
		set => SetAttributeValue(Fields.StudyPlan, value);
	}

	/// <summary>
	/// Program
	/// </summary>
	public EntityReference Program
	{
		get => GetAttributeValue<EntityReference>(Fields.Program);
		set => SetAttributeValue(Fields.Program, value);
	}

	/// <summary>
	/// TuitionFee
	/// </summary>
	public EntityReference TuitionFee
	{
		get => GetAttributeValue<EntityReference>(Fields.TuitionFee);
		set => SetAttributeValue(Fields.TuitionFee, value);
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
	/// Schema
	/// </summary>
	public struct Fields
	{
		/// <summary>
		/// Id
		/// </summary>
		public const string Id = "gd_invoiceid";
		
		/// <summary>
		/// Student
		/// </summary>
		public const string Student = "gd_student";

		/// <summary>
		/// StudyPlan
		/// </summary>
		public const string StudyPlan = "gd_studyplan";

		/// <summary>
		/// Program
		/// </summary>
		public const string Program = "gd_program";

		/// <summary>
		/// TuitionFee
		/// </summary>
		public const string TuitionFee = "gd_tuitionfee";

		/// <summary>
		/// StateCode
		/// </summary>
		public const string StateCode = "statecode";

		/// <summary>
		/// TransactionCurrencyId
		/// </summary>
		public const string TransactionCurrencyId = "transactioncurrencyid";
	}
}