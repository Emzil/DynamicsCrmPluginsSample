using System;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace Geddion.MU.Plugins.Model
{
	/// <summary>
	/// StudyModule entity
	/// </summary>
	[DataContract]
	[EntityLogicalName(EntityLogicalName)]
	public class StudyModule : Entity
	{
		/// <summary>
		/// Schema name
		/// </summary>
		public const string EntityLogicalName = "gd_studymodule";
		/// <summary>
		/// StudyModule
		/// </summary>
		public StudyModule() : base(EntityLogicalName)
		{

		}
		/// <summary>
		/// StudyModule
		/// </summary>
		/// <param name="id"></param>
		public StudyModule(Guid id) : base(EntityLogicalName, id)
		{
		}

		/// <summary>
		/// ModuleCode
		/// </summary>
		public string ModuleCode
		{
			get => GetAttributeValue<string>(Fields.ModuleCode);
			set => SetAttributeValue(Fields.ModuleCode, value);
		}
		
		/// <summary>
		/// GroupCode
		/// </summary>
		public string GroupCode
		{
			get => GetAttributeValue<string>(Fields.GroupCode);
			set => SetAttributeValue(Fields.GroupCode, value);
		}
		/// <summary>
		/// Requirement
		/// </summary>
		public OptionSetValue Requirement
		{
			get => GetAttributeValue<OptionSetValue>(Fields.Requirement);
			set => SetAttributeValue(Fields.Requirement, value);
		}
		/// <summary>
		/// OptionBlock
		/// </summary>
		public OptionSetValue OptionBlock
		{
			get => GetAttributeValue<OptionSetValue>(Fields.OptionBlock);
			set => SetAttributeValue(Fields.OptionBlock, value);
		}
		/// <summary>
		/// StudyMode
		/// </summary>
		public OptionSetValue StudyMode
		{
			get => GetAttributeValue<OptionSetValue>(Fields.StudyMode);
			set => SetAttributeValue(Fields.StudyMode, value);
		}
		/// <summary>
		/// ModMaxCredits
		/// </summary>
		public int ModMaxCredits
		{
			get => GetAttributeValue<int>(Fields.ModMaxCredits);
			set => SetAttributeValue(Fields.ModMaxCredits, value);
		}
		/// <summary>
		/// ModuleLengthWeeks
		/// </summary>
		public int ModuleLengthWeeks
		{
			get => GetAttributeValue<int>(Fields.ModuleLengthWeeks);
			set => SetAttributeValue(Fields.ModuleLengthWeeks, value);
		}

		/// <summary>
		/// Mdxmodule
		/// </summary>
		public EntityReference Mdxmodule
		{
			get => GetAttributeValue<EntityReference>(Fields.Mdxmodule);
			set => SetAttributeValue(Fields.Mdxmodule, value);
		}

		/// <summary>
		/// ProgramCode
		/// </summary>
		public EntityReference ProgramCode
		{
			get => GetAttributeValue<EntityReference>(Fields.ProgramCode);
			set => SetAttributeValue(Fields.ProgramCode, value);
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
		/// Schema
		/// </summary>
		public struct Fields
		{
			/// <summary>
			/// Id
			/// </summary>
			public const string Id = "gd_studymoduleid";
			/// <summary>
			/// ModuleCode
			/// </summary>
			public const string ModuleCode = "gd_modulecode";
			/// <summary>
			/// GroupCode
			/// </summary>
			public const string GroupCode = "gd_groupcode";
			/// <summary>
			/// Requirement
			/// </summary>
			public const string Requirement = "gd_requirement";
			/// <summary>
			/// OptionBlock
			/// </summary>
			public const string OptionBlock = "gd_optionblock";
			/// <summary>
			/// StudyMode
			/// </summary>
			public const string StudyMode = "gd_studymode";
			/// <summary>
			/// ModMaxCredits
			/// </summary>
			public const string ModMaxCredits = "gd_modcredits";
			/// <summary>
			/// ModuleLengthWeeks
			/// </summary>
			public const string ModuleLengthWeeks = "gd_modulelengthweeks";
			/// <summary>
			/// Mdxmodule
			/// </summary>
			public const string Mdxmodule = "gd_mdxmodule";
			/// <summary>
			/// ProgramCode
			/// </summary>
			public const string ProgramCode = "gd_programcode";
			/// <summary>
			/// StudyPlan
			/// </summary>
			public const string StudyPlan = "gd_studyplan";
			
		}
	}
}