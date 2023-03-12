using System;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace Geddion.MU.Plugins.Model
{
	/// <summary>
	/// MdxModule entity
	/// </summary>
	[DataContract]
	[EntityLogicalName(EntityLogicalName)]
	public class MdxModule : Entity
	{
		/// <summary>
		/// Schema name
		/// </summary>
		public const string EntityLogicalName = "gd_mdxmodule";
		/// <summary>
		/// MdxModule
		/// </summary>
		public MdxModule() : base(EntityLogicalName)
		{

		}
		/// <summary>
		/// MdxModule
		/// </summary>
		/// <param name="id"></param>
		public MdxModule(Guid id) : base(EntityLogicalName, id)
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
		/// ModTitle
		/// </summary>
		public string ModTitle
		{
			get => GetAttributeValue<string>(Fields.ModTitle);
			set => SetAttributeValue(Fields.ModTitle, value);
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
		/// Schema
		/// </summary>
		public struct Fields
		{
			/// <summary>
			/// Id
			/// </summary>
			public const string Id = "gd_mdxmoduleid";
			/// <summary>
			/// ModuleCode
			/// </summary>
			public const string ModuleCode = "gd_modulecode";
			/// <summary>
			/// ModTitle
			/// </summary>
			public const string ModTitle = "gd_modtitle";
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
			public const string ModMaxCredits = "gd_modmaxcredits";
			/// <summary>
			/// ModuleLengthWeeks
			/// </summary>
			public const string ModuleLengthWeeks = "gd_modulelengthweeks";
		}
	}
}