using System;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace Geddion.MU.Plugins.Model
{
	/// <summary>
	/// WhatsAppNumber entity
	/// </summary>
	[DataContract]
	[EntityLogicalName(EntityLogicalName)]
	public class Prospect : Entity
	{
		/// <summary>
		/// Schema name
		/// </summary>
		public const string EntityLogicalName = "gd_prospect";
		/// <summary>
		/// Prospect
		/// </summary>
		public Prospect() : base(EntityLogicalName)
		{

		}
		/// <summary>
		/// Prospect
		/// </summary>
		/// <param name="id"></param>
		public Prospect(Guid id) : base(EntityLogicalName, id)
		{
		}

		/// <summary>
		/// PhoneNumber
		/// </summary>
		public string PhoneNumber
		{
			get => GetAttributeValue<string>(Fields.PhoneNumber);
			set => SetAttributeValue(Fields.PhoneNumber, value);
		}

		/// <summary>
		/// Schema
		/// </summary>
		public struct Fields
		{
			/// <summary>
			/// Id
			/// </summary>
			public const string Id = "gd_prospectid";
			/// <summary>
			///  PhoneNumber
			/// </summary>
			public const string PhoneNumber = "gd_telephone";
		}
	}
}