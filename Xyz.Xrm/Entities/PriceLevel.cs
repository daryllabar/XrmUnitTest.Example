//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Xyz.Xrm.Entities
{
	
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.0.1.7297")]
	public enum PriceLevelState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// Entity that defines pricing levels.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("pricelevel")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.0.1.7297")]
	public partial class PriceLevel : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public struct Fields
		{
			public const string BeginDate = "begindate";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string Description = "description";
			public const string EndDate = "enddate";
			public const string ExchangeRate = "exchangerate";
			public const string FreightTermsCode = "freighttermscode";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Name = "name";
			public const string OrganizationId = "organizationid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string PaymentMethodCode = "paymentmethodcode";
			public const string PriceLevelId = "pricelevelid";
			public const string Id = "pricelevelid";
			public const string ShippingMethodCode = "shippingmethodcode";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
			public const string lk_pricelevel_createdonbehalfby = "lk_pricelevel_createdonbehalfby";
			public const string lk_pricelevel_modifiedonbehalfby = "lk_pricelevel_modifiedonbehalfby";
			public const string lk_pricelevelbase_createdby = "lk_pricelevelbase_createdby";
			public const string lk_pricelevelbase_modifiedby = "lk_pricelevelbase_modifiedby";
			public const string organization_price_levels = "organization_price_levels";
			public const string transactioncurrency_pricelevel = "transactioncurrency_pricelevel";
		}

		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public PriceLevel() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "pricelevel";
		
		public const int EntityTypeCode = 1022;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>
		/// Date on which the price list becomes effective.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("begindate")]
		public System.Nullable<System.DateTime> BeginDate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("begindate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("BeginDate");
				this.SetAttributeValue("begindate", value);
				this.OnPropertyChanged("BeginDate");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedBy");
				this.SetAttributeValue("createdby", value);
				this.OnPropertyChanged("CreatedBy");
			}
		}
		
		/// <summary>
		/// Date and time when the price list was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedOn");
				this.SetAttributeValue("createdon", value);
				this.OnPropertyChanged("CreatedOn");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the pricelevel.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedOnBehalfBy");
				this.SetAttributeValue("createdonbehalfby", value);
				this.OnPropertyChanged("CreatedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Description of the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Description");
				this.SetAttributeValue("description", value);
				this.OnPropertyChanged("Description");
			}
		}
		
		/// <summary>
		/// Date that is the last day the price list is valid.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("enddate")]
		public System.Nullable<System.DateTime> EndDate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("enddate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EndDate");
				this.SetAttributeValue("enddate", value);
				this.OnPropertyChanged("EndDate");
			}
		}
		
		/// <summary>
		/// Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
		public System.Nullable<decimal> ExchangeRate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
			}
		}
		
		/// <summary>
		/// Freight terms for the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("freighttermscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue FreightTermsCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("freighttermscode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FreightTermsCode");
				this.SetAttributeValue("freighttermscode", value);
				this.OnPropertyChanged("FreightTermsCode");
			}
		}
		
		/// <summary>
		/// Unique identifier of the data import or data migration that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedBy");
				this.SetAttributeValue("modifiedby", value);
				this.OnPropertyChanged("ModifiedBy");
			}
		}
		
		/// <summary>
		/// Date and time when the price list was last modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedOn");
				this.SetAttributeValue("modifiedon", value);
				this.OnPropertyChanged("ModifiedOn");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the pricelevel.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedOnBehalfBy");
				this.SetAttributeValue("modifiedonbehalfby", value);
				this.OnPropertyChanged("ModifiedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Name of the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization associated with the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Payment terms to use with the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("paymentmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PaymentMethodCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("paymentmethodcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PaymentMethodCode");
				this.SetAttributeValue("paymentmethodcode", value);
				this.OnPropertyChanged("PaymentMethodCode");
			}
		}
		
		/// <summary>
		/// Unique identifier of the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricelevelid")]
		public System.Nullable<System.Guid> PriceLevelId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("pricelevelid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PriceLevelId");
				this.SetAttributeValue("pricelevelid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("PriceLevelId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricelevelid")]
		public override System.Guid Id
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return base.Id;
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.PriceLevelId = value;
			}
		}
		
		/// <summary>
		/// Method of shipment for products in the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shippingmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue ShippingMethodCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("shippingmethodcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ShippingMethodCode");
				this.SetAttributeValue("shippingmethodcode", value);
				this.OnPropertyChanged("ShippingMethodCode");
			}
		}
		
		/// <summary>
		/// Status of the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<Xyz.Xrm.Entities.PriceLevelState> StateCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((Xyz.Xrm.Entities.PriceLevelState)(System.Enum.ToObject(typeof(Xyz.Xrm.Entities.PriceLevelState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StateCode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("StateCode");
			}
		}
		
		/// <summary>
		/// Reason for the status of the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StatusCode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("StatusCode");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Unique identifier of the currency associated with the price level.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TransactionCurrencyId");
				this.SetAttributeValue("transactioncurrencyid", value);
				this.OnPropertyChanged("TransactionCurrencyId");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// Version number of the price level.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// 1:N price_level_accounts
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("price_level_accounts")]
		public System.Collections.Generic.IEnumerable<Xyz.Xrm.Entities.Account> price_level_accounts
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Xyz.Xrm.Entities.Account>("price_level_accounts", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("price_level_accounts");
				this.SetRelatedEntities<Xyz.Xrm.Entities.Account>("price_level_accounts", null, value);
				this.OnPropertyChanged("price_level_accounts");
			}
		}
		
		/// <summary>
		/// 1:N price_level_contacts
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("price_level_contacts")]
		public System.Collections.Generic.IEnumerable<Xyz.Xrm.Entities.Contact> price_level_contacts
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Xyz.Xrm.Entities.Contact>("price_level_contacts", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("price_level_contacts");
				this.SetRelatedEntities<Xyz.Xrm.Entities.Contact>("price_level_contacts", null, value);
				this.OnPropertyChanged("price_level_contacts");
			}
		}
		
		/// <summary>
		/// 1:N price_level_invoices
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("price_level_invoices")]
		public System.Collections.Generic.IEnumerable<Xyz.Xrm.Entities.Invoice> price_level_invoices
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Xyz.Xrm.Entities.Invoice>("price_level_invoices", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("price_level_invoices");
				this.SetRelatedEntities<Xyz.Xrm.Entities.Invoice>("price_level_invoices", null, value);
				this.OnPropertyChanged("price_level_invoices");
			}
		}
		
		/// <summary>
		/// 1:N price_level_opportunties
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("price_level_opportunties")]
		public System.Collections.Generic.IEnumerable<Xyz.Xrm.Entities.Opportunity> price_level_opportunties
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Xyz.Xrm.Entities.Opportunity>("price_level_opportunties", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("price_level_opportunties");
				this.SetRelatedEntities<Xyz.Xrm.Entities.Opportunity>("price_level_opportunties", null, value);
				this.OnPropertyChanged("price_level_opportunties");
			}
		}
		
		/// <summary>
		/// 1:N price_level_orders
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("price_level_orders")]
		public System.Collections.Generic.IEnumerable<Xyz.Xrm.Entities.SalesOrder> price_level_orders
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Xyz.Xrm.Entities.SalesOrder>("price_level_orders", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("price_level_orders");
				this.SetRelatedEntities<Xyz.Xrm.Entities.SalesOrder>("price_level_orders", null, value);
				this.OnPropertyChanged("price_level_orders");
			}
		}
		
		/// <summary>
		/// 1:N price_level_product_price_levels
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("price_level_product_price_levels")]
		public System.Collections.Generic.IEnumerable<Xyz.Xrm.Entities.ProductPriceLevel> price_level_product_price_levels
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Xyz.Xrm.Entities.ProductPriceLevel>("price_level_product_price_levels", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("price_level_product_price_levels");
				this.SetRelatedEntities<Xyz.Xrm.Entities.ProductPriceLevel>("price_level_product_price_levels", null, value);
				this.OnPropertyChanged("price_level_product_price_levels");
			}
		}
		
		/// <summary>
		/// 1:N price_level_products
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("price_level_products")]
		public System.Collections.Generic.IEnumerable<Xyz.Xrm.Entities.Product> price_level_products
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Xyz.Xrm.Entities.Product>("price_level_products", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("price_level_products");
				this.SetRelatedEntities<Xyz.Xrm.Entities.Product>("price_level_products", null, value);
				this.OnPropertyChanged("price_level_products");
			}
		}
		
		/// <summary>
		/// 1:N price_level_quotes
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("price_level_quotes")]
		public System.Collections.Generic.IEnumerable<Xyz.Xrm.Entities.Quote> price_level_quotes
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Xyz.Xrm.Entities.Quote>("price_level_quotes", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("price_level_quotes");
				this.SetRelatedEntities<Xyz.Xrm.Entities.Quote>("price_level_quotes", null, value);
				this.OnPropertyChanged("price_level_quotes");
			}
		}
		
		/// <summary>
		/// 1:N PriceLevel_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("PriceLevel_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<Xyz.Xrm.Entities.AsyncOperation> PriceLevel_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Xyz.Xrm.Entities.AsyncOperation>("PriceLevel_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PriceLevel_AsyncOperations");
				this.SetRelatedEntities<Xyz.Xrm.Entities.AsyncOperation>("PriceLevel_AsyncOperations", null, value);
				this.OnPropertyChanged("PriceLevel_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N PriceLevel_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("PriceLevel_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<Xyz.Xrm.Entities.BulkDeleteFailure> PriceLevel_BulkDeleteFailures
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Xyz.Xrm.Entities.BulkDeleteFailure>("PriceLevel_BulkDeleteFailures", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PriceLevel_BulkDeleteFailures");
				this.SetRelatedEntities<Xyz.Xrm.Entities.BulkDeleteFailure>("PriceLevel_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("PriceLevel_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N pricelevel_connections1
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("pricelevel_connections1")]
		public System.Collections.Generic.IEnumerable<Xyz.Xrm.Entities.Connection> pricelevel_connections1
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Xyz.Xrm.Entities.Connection>("pricelevel_connections1", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("pricelevel_connections1");
				this.SetRelatedEntities<Xyz.Xrm.Entities.Connection>("pricelevel_connections1", null, value);
				this.OnPropertyChanged("pricelevel_connections1");
			}
		}
		
		/// <summary>
		/// 1:N pricelevel_connections2
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("pricelevel_connections2")]
		public System.Collections.Generic.IEnumerable<Xyz.Xrm.Entities.Connection> pricelevel_connections2
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Xyz.Xrm.Entities.Connection>("pricelevel_connections2", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("pricelevel_connections2");
				this.SetRelatedEntities<Xyz.Xrm.Entities.Connection>("pricelevel_connections2", null, value);
				this.OnPropertyChanged("pricelevel_connections2");
			}
		}
		
		/// <summary>
		/// 1:N pricelevel_principalobjectattributeaccess
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("pricelevel_principalobjectattributeaccess")]
		public System.Collections.Generic.IEnumerable<Xyz.Xrm.Entities.PrincipalObjectAttributeAccess> pricelevel_principalobjectattributeaccess
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Xyz.Xrm.Entities.PrincipalObjectAttributeAccess>("pricelevel_principalobjectattributeaccess", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("pricelevel_principalobjectattributeaccess");
				this.SetRelatedEntities<Xyz.Xrm.Entities.PrincipalObjectAttributeAccess>("pricelevel_principalobjectattributeaccess", null, value);
				this.OnPropertyChanged("pricelevel_principalobjectattributeaccess");
			}
		}
		
		/// <summary>
		/// 1:N PriceLevel_ProcessSessions
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("PriceLevel_ProcessSessions")]
		public System.Collections.Generic.IEnumerable<Xyz.Xrm.Entities.ProcessSession> PriceLevel_ProcessSessions
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Xyz.Xrm.Entities.ProcessSession>("PriceLevel_ProcessSessions", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PriceLevel_ProcessSessions");
				this.SetRelatedEntities<Xyz.Xrm.Entities.ProcessSession>("PriceLevel_ProcessSessions", null, value);
				this.OnPropertyChanged("PriceLevel_ProcessSessions");
			}
		}
		
		/// <summary>
		/// 1:N PriceList_Campaigns
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("PriceList_Campaigns")]
		public System.Collections.Generic.IEnumerable<Xyz.Xrm.Entities.Campaign> PriceList_Campaigns
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Xyz.Xrm.Entities.Campaign>("PriceList_Campaigns", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PriceList_Campaigns");
				this.SetRelatedEntities<Xyz.Xrm.Entities.Campaign>("PriceList_Campaigns", null, value);
				this.OnPropertyChanged("PriceList_Campaigns");
			}
		}
		
		/// <summary>
		/// 1:N userentityinstancedata_pricelevel
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_pricelevel")]
		public System.Collections.Generic.IEnumerable<Xyz.Xrm.Entities.UserEntityInstanceData> userentityinstancedata_pricelevel
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Xyz.Xrm.Entities.UserEntityInstanceData>("userentityinstancedata_pricelevel", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("userentityinstancedata_pricelevel");
				this.SetRelatedEntities<Xyz.Xrm.Entities.UserEntityInstanceData>("userentityinstancedata_pricelevel", null, value);
				this.OnPropertyChanged("userentityinstancedata_pricelevel");
			}
		}
		
		/// <summary>
		/// N:1 lk_pricelevel_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_pricelevel_createdonbehalfby")]
		public Xyz.Xrm.Entities.SystemUser lk_pricelevel_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.SystemUser>("lk_pricelevel_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_pricelevel_createdonbehalfby");
				this.SetRelatedEntity<Xyz.Xrm.Entities.SystemUser>("lk_pricelevel_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_pricelevel_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_pricelevel_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_pricelevel_modifiedonbehalfby")]
		public Xyz.Xrm.Entities.SystemUser lk_pricelevel_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.SystemUser>("lk_pricelevel_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_pricelevel_modifiedonbehalfby");
				this.SetRelatedEntity<Xyz.Xrm.Entities.SystemUser>("lk_pricelevel_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_pricelevel_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_pricelevelbase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_pricelevelbase_createdby")]
		public Xyz.Xrm.Entities.SystemUser lk_pricelevelbase_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.SystemUser>("lk_pricelevelbase_createdby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_pricelevelbase_createdby");
				this.SetRelatedEntity<Xyz.Xrm.Entities.SystemUser>("lk_pricelevelbase_createdby", null, value);
				this.OnPropertyChanged("lk_pricelevelbase_createdby");
			}
		}
		
		/// <summary>
		/// N:1 lk_pricelevelbase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_pricelevelbase_modifiedby")]
		public Xyz.Xrm.Entities.SystemUser lk_pricelevelbase_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.SystemUser>("lk_pricelevelbase_modifiedby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_pricelevelbase_modifiedby");
				this.SetRelatedEntity<Xyz.Xrm.Entities.SystemUser>("lk_pricelevelbase_modifiedby", null, value);
				this.OnPropertyChanged("lk_pricelevelbase_modifiedby");
			}
		}
		
		/// <summary>
		/// N:1 organization_price_levels
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_price_levels")]
		public Xyz.Xrm.Entities.Organization organization_price_levels
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.Organization>("organization_price_levels", null);
			}
		}
		
		/// <summary>
		/// N:1 transactioncurrency_pricelevel
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_pricelevel")]
		public Xyz.Xrm.Entities.TransactionCurrency transactioncurrency_pricelevel
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.TransactionCurrency>("transactioncurrency_pricelevel", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("transactioncurrency_pricelevel");
				this.SetRelatedEntity<Xyz.Xrm.Entities.TransactionCurrency>("transactioncurrency_pricelevel", null, value);
				this.OnPropertyChanged("transactioncurrency_pricelevel");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public PriceLevel(object anonymousType) : 
				this()
		{
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                var name = p.Name.ToLower();
            
                if (name.EndsWith("enum") && value.GetType().BaseType == typeof(System.Enum))
                {
                    value = new Microsoft.Xrm.Sdk.OptionSetValue((int) value);
                    name = name.Remove(name.Length - "enum".Length);
                }
            
                switch (name)
                {
                    case "id":
                        base.Id = (System.Guid)value;
                        Attributes["pricelevelid"] = base.Id;
                        break;
                    case "pricelevelid":
                        var id = (System.Nullable<System.Guid>) value;
                        if(id == null){ continue; }
                        base.Id = id.Value;
                        Attributes[name] = base.Id;
                        break;
                    case "formattedvalues":
                        // Add Support for FormattedValues
                        FormattedValues.AddRange((Microsoft.Xrm.Sdk.FormattedValueCollection)value);
                        break;
                    default:
                        Attributes[name] = value;
                        break;
                }
            }
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("freighttermscode")]
		public virtual PriceLevel_FreightTermsCode? FreightTermsCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((PriceLevel_FreightTermsCode?)(EntityOptionSetEnum.GetEnum(this, "freighttermscode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				FreightTermsCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("paymentmethodcode")]
		public virtual PriceLevel_PaymentMethodCode? PaymentMethodCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((PriceLevel_PaymentMethodCode?)(EntityOptionSetEnum.GetEnum(this, "paymentmethodcode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				PaymentMethodCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shippingmethodcode")]
		public virtual PriceLevel_ShippingMethodCode? ShippingMethodCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((PriceLevel_ShippingMethodCode?)(EntityOptionSetEnum.GetEnum(this, "shippingmethodcode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				ShippingMethodCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public virtual PriceLevel_StatusCode? StatusCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((PriceLevel_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				StatusCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}