using System;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace Geddion.MU.Plugins.Model
{
	/// <summary>
	/// Program entity
	/// </summary>
	[DataContract]
	[EntityLogicalName(EntityLogicalName)]
	public class Program : Entity
	{
		/// <summary>
		/// Schema name
		/// </summary>
		public const string EntityLogicalName = "gd_program";
		/// <summary>
		/// Program
		/// </summary>
		public Program() : base(EntityLogicalName)
		{

		}
		/// <summary>
		/// Program
		/// </summary>
		/// <param name="id"></param>
		public Program(Guid id) : base(EntityLogicalName, id)
		{
		}

		/// <summary>
		/// ProgramTitle
		/// </summary>
		public string ProgramTitle
		{
			get => GetAttributeValue<string>(Fields.ProgramTitle);
			set => SetAttributeValue(Fields.ProgramTitle, value);
		}

		/// <summary>
		/// Schema
		/// </summary>
		public struct Fields
		{
			/// <summary>
			/// Id
			/// </summary>
			public const string Id = "gd_programid";
			
			/// <summary>
			/// Id
			/// </summary>
			public const string ProgramTitle = "gd_programtitle";
		}
	}
}