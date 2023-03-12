using System;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace Geddion.MU.Plugins.Model
{
	/// <summary>
	/// ProgramFeeDatabase entity
	/// </summary>
	[DataContract]
	[EntityLogicalName(EntityLogicalName)]
	public class ProgramFeeDatabase : Entity
	{
		/// <summary>
		/// Schema name
		/// </summary>
		public const string EntityLogicalName = "gd_programfeedatabase";
		/// <summary>
		/// ProgramFeeDatabase
		/// </summary>
		public ProgramFeeDatabase() : base(EntityLogicalName)
		{

		}
		/// <summary>
		/// StudyPlan
		/// </summary>
		/// <param name="id"></param>
		public ProgramFeeDatabase(Guid id) : base(EntityLogicalName, id)
		{
		}
		

		/// <summary>
		/// YearOfEnrolment
		/// </summary>
		public string YearOfEnrolment
		{
			get => GetAttributeValue<string>(Fields.YearOfEnrolment);
			set => SetAttributeValue(Fields.YearOfEnrolment, value);
		}

		/// <summary>
		/// LocalInternational
		/// </summary>
		public OptionSetValue LocalInternational
		{
			get => GetAttributeValue<OptionSetValue>(Fields.LocalInternational);
			set => SetAttributeValue(Fields.LocalInternational, value);
		}

		/// <summary>
		/// FullTimePartTime
		/// </summary>
		public OptionSetValue FullTimePartTime
		{
			get => GetAttributeValue<OptionSetValue>(Fields.FullTimePartTime);
			set => SetAttributeValue(Fields.FullTimePartTime, value);
		}

		/// <summary>
		/// AdmissionType
		/// </summary>
		public OptionSetValue AdmissionType
		{
			get => GetAttributeValue<OptionSetValue>(Fields.AdmissionType);
			set => SetAttributeValue(Fields.AdmissionType, value);
		}

		/// <summary>
		/// FullPayment
		/// </summary>
		public Money FullPayment
		{
			get => GetAttributeValue<Money>(Fields.FullPayment);
			set => SetAttributeValue(Fields.FullPayment, value);
		}

		/// <summary>
		/// Deposit
		/// </summary>
		public Money Deposit
		{
			get => GetAttributeValue<Money>(Fields.Deposit);
			set => SetAttributeValue(Fields.Deposit, value);
		}
		

		/// <summary>
		/// Instalments_1
		/// </summary>
		public Money Instalments_1
		{
			get => GetAttributeValue<Money>(Fields.Instalments_1);
			set => SetAttributeValue(Fields.Instalments_1, value);
		}

		/// <summary>
		/// Instalments_2
		/// </summary>
		public Money Instalments_2
		{
			get => GetAttributeValue<Money>(Fields.Instalments_2);
			set => SetAttributeValue(Fields.Instalments_2, value);
		}

		/// <summary>
		/// Instalments_3
		/// </summary>
		public Money Instalments_3
		{
			get => GetAttributeValue<Money>(Fields.Instalments_3);
			set => SetAttributeValue(Fields.Instalments_3, value);
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
			public const string Id = "gd_programfeedatabaseid";
			/// <summary>
			///  YearOfEnrolment
			/// </summary>
			public const string YearOfEnrolment = "gd_yearofenrolment";
			/// <summary>
			/// LocalInternational
			/// </summary>
			public const string LocalInternational = "gd_localinternational";
			/// <summary>
			/// FullTimePartTime
			/// </summary>
			public const string FullTimePartTime = "gd_fulltimeparttime";
			/// <summary>
			/// AdmissionType
			/// </summary>
			public const string AdmissionType = "gd_admissiontype";
			/// <summary>
			/// FullPayment
			/// </summary>
			public const string FullPayment = "gd_fullpayment";
			/// <summary>
			/// Deposit
			/// </summary>
			public const string Deposit = "gd_deposit";
			/// <summary>
			/// Instalments_1
			/// </summary>
			public const string Instalments_1 = "gd_1instalments";
			/// <summary>
			/// Instalments_2
			/// </summary>
			public const string Instalments_2 = "gd_2instalments";
			/// <summary>
			/// Instalments_3
			/// </summary>
			public const string Instalments_3 = "gd_3";
			/// <summary>
			/// TransactionCurrencyId
			/// </summary>
			public const string TransactionCurrencyId = "transactioncurrencyid";
			/// <summary>
			/// ProgramName
			/// </summary>
			public const string ProgramName = "gd_programname";

		}
	}
}