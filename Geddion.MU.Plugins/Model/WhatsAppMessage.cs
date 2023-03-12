using Microsoft.Xrm.Sdk;
using System;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk.Client;

namespace Geddion.MU.Plugins.Model
{
	/// <summary>
	/// WhatsAppMessage entity
	/// </summary>
	[DataContract]
	[EntityLogicalName(EntityLogicalName)]
	public class WhatsAppMessage : Entity
	{
		/// <summary>
		/// Schema name
		/// </summary>
		public const string EntityLogicalName = "gd_whatsappmessage";
		/// <summary>
		/// WhatsAppMessage
		/// </summary>
		public WhatsAppMessage() : base(EntityLogicalName)
		{

		}
		/// <summary>
		/// WhatsAppMessage
		/// </summary>
		/// <param name="id"></param>
		public WhatsAppMessage(Guid id) : base(EntityLogicalName, id)
		{
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
		/// WhatsAppNumber
		/// </summary>
		public EntityReference WhatsAppNumber
		{
			get => GetAttributeValue<EntityReference>(Fields.WhatsAppNumberId);
			set => SetAttributeValue(Fields.WhatsAppNumberId, value);
		}

		/// <summary>
		/// Message
		/// </summary>
		public string Message
		{
			get => GetAttributeValue<string>(Fields.Message);
			set => SetAttributeValue(Fields.Message, value);
		}

		/// <summary>
		/// Regarding
		/// </summary>
		public EntityReference Regarding
		{
			get => GetAttributeValue<EntityReference>(Fields.Regarding);
			set => SetAttributeValue(Fields.Regarding, value);
		}

		/// <summary>
		/// StatusCode
		/// </summary>
		public OptionSetValue StatusCode
		{
			get => GetAttributeValue<OptionSetValue>(Fields.StatusCode);
			set => SetAttributeValue(Fields.StatusCode, value);
		}

		/// <summary>
		/// Schema
		/// </summary>
		public struct Fields
		{
			/// <summary>
			/// Id
			/// </summary>
			public const string Id = "gd_whatsappmessageid";
			/// <summary>
			///  WhatsAppAccount
			/// </summary>
			public const string WhatsAppAccountId = "gd_whatsappaccountid";
			/// <summary>
			/// WhatsAppNumber
			/// </summary>
			public const string WhatsAppNumberId = "gd_whatsappnumberid";
			/// <summary>
			/// Message
			/// </summary>
			public const string Message = "description";

			/// <summary>
			/// Regarding
			/// </summary>
			public const string Regarding = "regardingobjectid";

			/// <summary>
			/// StatusCode
			/// </summary>
			public const string StatusCode = "statuscode";
		}
	}
}
