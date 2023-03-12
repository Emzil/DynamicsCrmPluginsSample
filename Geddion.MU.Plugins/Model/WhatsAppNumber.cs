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
	public class WhatsAppNumber : Entity
	{
		/// <summary>
		/// Schema name
		/// </summary>
		public const string EntityLogicalName = "gd_whatsappnumber";
		/// <summary>
		/// WhatsAppNumber
		/// </summary>
		public WhatsAppNumber() : base(EntityLogicalName)
		{

		}
		/// <summary>
		/// WhatsAppNumber
		/// </summary>
		/// <param name="id"></param>
		public WhatsAppNumber(Guid id) : base(EntityLogicalName, id)
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
		/// WhatsAppAccount
		/// </summary>
		public EntityReference WhatsAppAccount
		{
			get => GetAttributeValue<EntityReference>(Fields.WhatsAppAccountId);
			set => SetAttributeValue(Fields.WhatsAppAccountId, value);
		}

		/// <summary>
		/// Schema
		/// </summary>
		public struct Fields
		{
			/// <summary>
			/// Id
			/// </summary>
			public const string Id = "gd_whatsappnumberid";
			/// <summary>
			///  PhoneNumber
			/// </summary>
			public const string PhoneNumber = "gd_phonenumber";
			/// <summary>
			///  WhatsAppAccount
			/// </summary>
			public const string WhatsAppAccountId = "gd_whatsappaccountid";
		}
	}
}