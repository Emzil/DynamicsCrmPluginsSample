using System;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace Geddion.MU.Plugins.Model
{
	/// <summary>
	/// TuitionFee entity
	/// </summary>
	[DataContract]
	[EntityLogicalName(EntityLogicalName)]
	public class TuitionFee : Entity
	{
		/// <summary>
		/// Schema name
		/// </summary>
		public const string EntityLogicalName = "gd_tuitionfee";
		/// <summary>
		/// TuitionFee
		/// </summary>
		public TuitionFee() : base(EntityLogicalName)
		{

		}
		/// <summary>
		/// TuitionFee
		/// </summary>
		/// <param name="id"></param>
		public TuitionFee(Guid id) : base(EntityLogicalName, id)
		{
		}

		/// <summary>
		/// TuitionFeeCredit
		/// </summary>
		public Money TuitionFeeCredit
		{
			get => GetAttributeValue<Money>(Fields.TuitionFee);
			set => SetAttributeValue(Fields.TuitionFee, value);
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
		/// StudyPlan
		/// </summary>
		public EntityReference StudyPlan
		{
			get => GetAttributeValue<EntityReference>(Fields.StudyPlan);
			set => SetAttributeValue(Fields.StudyPlan, value);
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
		/// StdProgramFee
		/// </summary>
		public EntityReference StdProgramFee
		{
			get => GetAttributeValue<EntityReference>(Fields.StdProgramFee);
			set => SetAttributeValue(Fields.StdProgramFee, value);
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
		/// NewExistingStudent
		/// </summary>
		public OptionSetValue NewExistingStudent
		{
			get => GetAttributeValue<OptionSetValue>(Fields.NewExistingStudent);
			set => SetAttributeValue(Fields.NewExistingStudent, value);
		}

		/// <summary>
		/// PaymentSchedule
		/// </summary>
		public OptionSetValue PaymentSchedule
		{
			get => GetAttributeValue<OptionSetValue>(Fields.PaymentSchedule);
			set => SetAttributeValue(Fields.PaymentSchedule, value);
		}

		/// <summary>
		/// NumberActiveModuleCredits
		/// </summary>
		public int NumberActiveModuleCredits
		{
			get => GetAttributeValue<int>(Fields.NumberActiveModuleCredits);
			set => SetAttributeValue(Fields.NumberActiveModuleCredits, value);
		}
		
		/// <summary>
		/// NumberActiveModuleCredits
		/// </summary>
		public Money TotalAmount
		{
			get => GetAttributeValue<Money>(Fields.TotalAmount);
			set => SetAttributeValue(Fields.TotalAmount, value);
		}

		/// <summary>
		/// Schema
		/// </summary>
		public struct Fields
		{
			/// <summary>
			/// Id
			/// </summary>
			public const string Id = "gd_tuitionfeeid";
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
			/// StudyPlan
			/// </summary>
			public const string StudyPlan = "gd_mystudyplan";
			/// <summary>
			/// TuitionFee
			/// </summary>
			public const string TuitionFee = "gd_tuitionfee";
			/// <summary>
			/// Deposit
			/// </summary>
			public const string Deposit = "gd_deposit";
			/// <summary>
			/// Instalments_1
			/// </summary>
			public const string Instalments_1 = "gd_1instalment";
			/// <summary>
			/// Instalments_2
			/// </summary>
			public const string Instalments_2 = "gd_2instalment";
			/// <summary>
			/// Instalments_3
			/// </summary>
			public const string Instalments_3 = "gd_3instalment";
			/// <summary>
			/// TransactionCurrencyId
			/// </summary>
			public const string TransactionCurrencyId = "transactioncurrencyid";
			/// <summary>
			/// StdProgramFee
			/// </summary>
			public const string StdProgramFee = "gd_stdprogramfee";
			/// <summary>
			/// Program
			/// </summary>
			public const string Program = "gd_program";
			/// <summary>
			/// NewExistingStudent
			/// </summary>
			public const string NewExistingStudent = "gd_newexistingstudent";
			/// <summary>
			/// PaymentSchedule
			/// </summary>
			public const string PaymentSchedule = "gd_payment";
			/// <summary>
			/// NumberActiveModuleCredits
			/// </summary>
			public const string NumberActiveModuleCredits = "gd_numberofactive";

			/// <summary>
			/// StateCode
			/// </summary>
			public const string StateCode = "statecode";

			/// <summary>
			/// TotalAmount
			/// </summary>
			public const string TotalAmount = "gd_totaltuitionfee";
		}
	}
}