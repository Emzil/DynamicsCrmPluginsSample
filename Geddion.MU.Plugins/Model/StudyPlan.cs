using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using System;
using System.Runtime.Serialization;

namespace Geddion.MU.Plugins.Model
{
	/// <summary>
	/// StudyPlan entity
	/// </summary>
	[DataContract]
	[EntityLogicalName(EntityLogicalName)]
	public class StudyPlan : Entity
	{
		/// <summary>
		/// Schema name
		/// </summary>
		public const string EntityLogicalName = "gd_studyplan";
		/// <summary>
		/// StudyPlan
		/// </summary>
		public StudyPlan() : base(EntityLogicalName)
		{

		}
		/// <summary>
		/// StudyPlan
		/// </summary>
		/// <param name="id"></param>
		public StudyPlan(Guid id) : base(EntityLogicalName, id)
		{
		}

		/// <summary>
		/// StudyProgram
		/// </summary>
		public EntityReference StudyProgram
		{
			get => GetAttributeValue<EntityReference>(Fields.StudyProgram);
			set => SetAttributeValue(Fields.StudyProgram, value);
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
		/// Category
		/// </summary>
		public OptionSetValue Category
		{
			get => GetAttributeValue<OptionSetValue>(Fields.Category);
			set => SetAttributeValue(Fields.Category, value);
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
		/// Student
		/// </summary>
		public EntityReference Student
		{
			get => GetAttributeValue<EntityReference>(Fields.Student);
			set => SetAttributeValue(Fields.Student, value);
		}

		/// <summary>
		/// Schema
		/// </summary>
		public struct Fields
		{
			/// <summary>
			/// Id
			/// </summary>
			public const string Id = "gd_studyprogramid";
			/// <summary>
			///  PhoneNumber
			/// </summary>
			public const string StudyProgram = "gd_studyprogram";
			/// <summary>
			/// PlanStatus
			/// </summary>
			public const string PlanStatus = "gd_studyplanstatus";

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
			/// Category
			/// </summary>
			public const string Category = "gd_category";
			/// <summary>
			/// Program
			/// </summary>
			public const string Program = "gd_studyprogram";
			/// <summary>
			/// NewExistingStudent
			/// </summary>
			public const string NewExistingStudent = "gd_newexistingstudent";
			/// <summary>
			/// PaymentSchedule
			/// </summary>
			public const string PaymentSchedule = "gd_paymentschedule";
			/// <summary>
			/// NumberActiveModuleCredits
			/// </summary>
			public const string NumberActiveModuleCredits = "gd_numberactivemodulecredits";

			/// <summary>
			/// Student
			/// </summary>
			public const string Student = "gd_student";
		}
	}
}
