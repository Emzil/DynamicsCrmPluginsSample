using System;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace Geddion.MU.Plugins.Model
{
	/// <summary>
	/// WhatsAppAccount entity
	/// </summary>
	[DataContract]
	[EntityLogicalName(EntityLogicalName)]
	public class WhatsAppAccount : Entity
	{
		/// <summary>
		/// Schema name
		/// </summary>
		public const string EntityLogicalName = "gd_whatsappaccount";
		/// <summary>
		/// WhatsAppAccount
		/// </summary>
		public WhatsAppAccount() : base(EntityLogicalName)
		{

		}
		/// <summary>
		/// WhatsAppAccount
		/// </summary>
		/// <param name="id"></param>
		public WhatsAppAccount(Guid id) : base(EntityLogicalName, id)
		{
		}

		/// <summary>
		/// AccountSid
		/// </summary>
		public string AccountSid
		{
			get => GetAttributeValue<string>(Fields.AccountSid);
			set => SetAttributeValue(Fields.AccountSid, value);
		}

		/// <summary>
		/// AuthToken
		/// </summary>
		public string AuthToken
		{
			get => GetAttributeValue<string>(Fields.AuthToken);
			set => SetAttributeValue(Fields.AuthToken, value);
		}

		/// <summary>
		/// Schema
		/// </summary>
		public struct Fields
		{
			/// <summary>
			/// Id
			/// </summary>
			public const string Id = "gd_whatsappaccountid";
			/// <summary>
			///  AccountSid
			/// </summary>
			public const string AccountSid = "gd_accountsid";
			/// <summary>
			/// AuthToken
			/// </summary>
			public const string AuthToken = "gd_authtoken";
		}
	}
}