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
	
	/// <summary>
	/// Defines free/busy times for a service and for resources or resource groups, such as working, non-working, vacation, and blocked.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("calendarrule")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.0.1.7297")]
	public partial class CalendarRule : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public struct Fields
		{
			public const string BusinessUnitId = "businessunitid";
			public const string CalendarId = "calendarid";
			public const string CalendarRuleId = "calendarruleid";
			public const string Id = "calendarruleid";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string Description = "description";
			public const string Duration = "duration";
			public const string EffectiveIntervalEnd = "effectiveintervalend";
			public const string EffectiveIntervalStart = "effectiveintervalstart";
			public const string Effort = "effort";
			public const string EndTime = "endtime";
			public const string ExtentCode = "extentcode";
			public const string GroupDesignator = "groupdesignator";
			public const string InnerCalendarId = "innercalendarid";
			public const string IsModified = "ismodified";
			public const string IsSelected = "isselected";
			public const string IsSimple = "issimple";
			public const string IsVaried = "isvaried";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Name = "name";
			public const string Offset = "offset";
			public const string OrganizationId = "organizationid";
			public const string Pattern = "pattern";
			public const string Rank = "rank";
			public const string ServiceId = "serviceid";
			public const string StartTime = "starttime";
			public const string SubCode = "subcode";
			public const string TimeCode = "timecode";
			public const string TimeZoneCode = "timezonecode";
			public const string VersionNumber = "versionnumber";
			public const string calendar_calendar_rules = "calendar_calendar_rules";
			public const string inner_calendar_calendar_rules = "inner_calendar_calendar_rules";
			public const string lk_calendarrule_createdby = "lk_calendarrule_createdby";
			public const string lk_calendarrule_createdonbehalfby = "lk_calendarrule_createdonbehalfby";
			public const string lk_calendarrule_modifiedby = "lk_calendarrule_modifiedby";
			public const string lk_calendarrule_modifiedonbehalfby = "lk_calendarrule_modifiedonbehalfby";
			public const string service_calendar_rules = "service_calendar_rules";
		}

		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public CalendarRule() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "calendarrule";
		
		public const int EntityTypeCode = 4004;
		
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
		/// Unique identifier of the business unit with which the calendar rule is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
		public System.Nullable<System.Guid> BusinessUnitId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("businessunitid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the calendar with which the calendar rule is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("calendarid")]
		public Microsoft.Xrm.Sdk.EntityReference CalendarId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("calendarid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CalendarId");
				this.SetAttributeValue("calendarid", value);
				this.OnPropertyChanged("CalendarId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the calendar rule.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("calendarruleid")]
		public System.Nullable<System.Guid> CalendarRuleId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("calendarruleid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CalendarRuleId");
				this.SetAttributeValue("calendarruleid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("CalendarRuleId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("calendarruleid")]
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
				this.CalendarRuleId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the calendar rule.
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
		/// Date and time when the calendar rule was created.
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
		/// Unique identifier of the delegate user who created the calendarrule.
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
		/// Defines free/busy times for a service and for resources or resource groups, such as working, non-working, vacation, and blocked.
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
		/// Duration of the calendar rule in minutes.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duration")]
		public System.Nullable<int> Duration
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("duration");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Duration");
				this.SetAttributeValue("duration", value);
				this.OnPropertyChanged("Duration");
			}
		}
		
		/// <summary>
		/// Effective interval end of the calendar rule.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("effectiveintervalend")]
		public System.Nullable<System.DateTime> EffectiveIntervalEnd
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("effectiveintervalend");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EffectiveIntervalEnd");
				this.SetAttributeValue("effectiveintervalend", value);
				this.OnPropertyChanged("EffectiveIntervalEnd");
			}
		}
		
		/// <summary>
		/// Effective interval start of the calendar rule.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("effectiveintervalstart")]
		public System.Nullable<System.DateTime> EffectiveIntervalStart
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("effectiveintervalstart");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EffectiveIntervalStart");
				this.SetAttributeValue("effectiveintervalstart", value);
				this.OnPropertyChanged("EffectiveIntervalStart");
			}
		}
		
		/// <summary>
		/// Effort available for a resource during the time described by the calendar rule.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("effort")]
		public System.Nullable<double> Effort
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("effort");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Effort");
				this.SetAttributeValue("effort", value);
				this.OnPropertyChanged("Effort");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("endtime")]
		public System.Nullable<System.DateTime> EndTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("endtime");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EndTime");
				this.SetAttributeValue("endtime", value);
				this.OnPropertyChanged("EndTime");
			}
		}
		
		/// <summary>
		/// Extent of the calendar rule.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("extentcode")]
		public System.Nullable<int> ExtentCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("extentcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ExtentCode");
				this.SetAttributeValue("extentcode", value);
				this.OnPropertyChanged("ExtentCode");
			}
		}
		
		/// <summary>
		/// Unique identifier of the group.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("groupdesignator")]
		public string GroupDesignator
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("groupdesignator");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("GroupDesignator");
				this.SetAttributeValue("groupdesignator", value);
				this.OnPropertyChanged("GroupDesignator");
			}
		}
		
		/// <summary>
		/// Unique identifier of the inner calendar for non-leaf calendar rules.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("innercalendarid")]
		public Microsoft.Xrm.Sdk.EntityReference InnerCalendarId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("innercalendarid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("InnerCalendarId");
				this.SetAttributeValue("innercalendarid", value);
				this.OnPropertyChanged("InnerCalendarId");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismodified")]
		public System.Nullable<bool> IsModified
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("ismodified");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsModified");
				this.SetAttributeValue("ismodified", value);
				this.OnPropertyChanged("IsModified");
			}
		}
		
		/// <summary>
		/// Flag used in vary-by-day calendar rules.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isselected")]
		public System.Nullable<bool> IsSelected
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isselected");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsSelected");
				this.SetAttributeValue("isselected", value);
				this.OnPropertyChanged("IsSelected");
			}
		}
		
		/// <summary>
		/// Flag used in vary-by-day calendar rules.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("issimple")]
		public System.Nullable<bool> IsSimple
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("issimple");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsSimple");
				this.SetAttributeValue("issimple", value);
				this.OnPropertyChanged("IsSimple");
			}
		}
		
		/// <summary>
		/// Flag used in leaf nonrecurring rules.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isvaried")]
		public System.Nullable<bool> IsVaried
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isvaried");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsVaried");
				this.SetAttributeValue("isvaried", value);
				this.OnPropertyChanged("IsVaried");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the calendar rule.
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
		/// Date and time when the calendar rule was last modified.
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
		/// Unique identifier of the delegate user who last modified the calendarrule.
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
		/// Name of the calendar rule.
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
		/// Start offset for leaf nonrecurring rules.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("offset")]
		public System.Nullable<int> Offset
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("offset");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Offset");
				this.SetAttributeValue("offset", value);
				this.OnPropertyChanged("Offset");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization with which the calendar rule is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public System.Nullable<System.Guid> OrganizationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("organizationid");
			}
		}
		
		/// <summary>
		/// Pattern of the rule recurrence.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pattern")]
		public string Pattern
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("pattern");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Pattern");
				this.SetAttributeValue("pattern", value);
				this.OnPropertyChanged("Pattern");
			}
		}
		
		/// <summary>
		/// Rank of the calendar rule.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rank")]
		public System.Nullable<int> Rank
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("rank");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Rank");
				this.SetAttributeValue("rank", value);
				this.OnPropertyChanged("Rank");
			}
		}
		
		/// <summary>
		/// Unique identifier of the service with which the calendar rule is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("serviceid")]
		public Microsoft.Xrm.Sdk.EntityReference ServiceId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("serviceid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ServiceId");
				this.SetAttributeValue("serviceid", value);
				this.OnPropertyChanged("ServiceId");
			}
		}
		
		/// <summary>
		/// Start time for the rule.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("starttime")]
		public System.Nullable<System.DateTime> StartTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("starttime");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StartTime");
				this.SetAttributeValue("starttime", value);
				this.OnPropertyChanged("StartTime");
			}
		}
		
		/// <summary>
		/// Sub-type of calendar rule.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subcode")]
		public System.Nullable<int> SubCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("subcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SubCode");
				this.SetAttributeValue("subcode", value);
				this.OnPropertyChanged("SubCode");
			}
		}
		
		/// <summary>
		/// Type of calendar rule such as working hours, break, holiday, or time off.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timecode")]
		public System.Nullable<int> TimeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TimeCode");
				this.SetAttributeValue("timecode", value);
				this.OnPropertyChanged("TimeCode");
			}
		}
		
		/// <summary>
		/// Local time zone for the calendar rule.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezonecode")]
		public System.Nullable<int> TimeZoneCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezonecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TimeZoneCode");
				this.SetAttributeValue("timezonecode", value);
				this.OnPropertyChanged("TimeZoneCode");
			}
		}
		
		/// <summary>
		/// 
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
		/// 1:N userentityinstancedata_calendarrule
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_calendarrule")]
		public System.Collections.Generic.IEnumerable<Xyz.Xrm.Entities.UserEntityInstanceData> userentityinstancedata_calendarrule
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Xyz.Xrm.Entities.UserEntityInstanceData>("userentityinstancedata_calendarrule", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("userentityinstancedata_calendarrule");
				this.SetRelatedEntities<Xyz.Xrm.Entities.UserEntityInstanceData>("userentityinstancedata_calendarrule", null, value);
				this.OnPropertyChanged("userentityinstancedata_calendarrule");
			}
		}
		
		/// <summary>
		/// N:1 calendar_calendar_rules
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("calendarid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("calendar_calendar_rules")]
		public Xyz.Xrm.Entities.Calendar calendar_calendar_rules
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.Calendar>("calendar_calendar_rules", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("calendar_calendar_rules");
				this.SetRelatedEntity<Xyz.Xrm.Entities.Calendar>("calendar_calendar_rules", null, value);
				this.OnPropertyChanged("calendar_calendar_rules");
			}
		}
		
		/// <summary>
		/// N:1 inner_calendar_calendar_rules
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("innercalendarid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("inner_calendar_calendar_rules")]
		public Xyz.Xrm.Entities.Calendar inner_calendar_calendar_rules
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.Calendar>("inner_calendar_calendar_rules", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("inner_calendar_calendar_rules");
				this.SetRelatedEntity<Xyz.Xrm.Entities.Calendar>("inner_calendar_calendar_rules", null, value);
				this.OnPropertyChanged("inner_calendar_calendar_rules");
			}
		}
		
		/// <summary>
		/// N:1 lk_calendarrule_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_calendarrule_createdby")]
		public Xyz.Xrm.Entities.SystemUser lk_calendarrule_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.SystemUser>("lk_calendarrule_createdby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_calendarrule_createdby");
				this.SetRelatedEntity<Xyz.Xrm.Entities.SystemUser>("lk_calendarrule_createdby", null, value);
				this.OnPropertyChanged("lk_calendarrule_createdby");
			}
		}
		
		/// <summary>
		/// N:1 lk_calendarrule_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_calendarrule_createdonbehalfby")]
		public Xyz.Xrm.Entities.SystemUser lk_calendarrule_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.SystemUser>("lk_calendarrule_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_calendarrule_createdonbehalfby");
				this.SetRelatedEntity<Xyz.Xrm.Entities.SystemUser>("lk_calendarrule_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_calendarrule_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_calendarrule_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_calendarrule_modifiedby")]
		public Xyz.Xrm.Entities.SystemUser lk_calendarrule_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.SystemUser>("lk_calendarrule_modifiedby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_calendarrule_modifiedby");
				this.SetRelatedEntity<Xyz.Xrm.Entities.SystemUser>("lk_calendarrule_modifiedby", null, value);
				this.OnPropertyChanged("lk_calendarrule_modifiedby");
			}
		}
		
		/// <summary>
		/// N:1 lk_calendarrule_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_calendarrule_modifiedonbehalfby")]
		public Xyz.Xrm.Entities.SystemUser lk_calendarrule_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.SystemUser>("lk_calendarrule_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_calendarrule_modifiedonbehalfby");
				this.SetRelatedEntity<Xyz.Xrm.Entities.SystemUser>("lk_calendarrule_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_calendarrule_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 service_calendar_rules
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("serviceid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("service_calendar_rules")]
		public Xyz.Xrm.Entities.Service service_calendar_rules
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.Service>("service_calendar_rules", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("service_calendar_rules");
				this.SetRelatedEntity<Xyz.Xrm.Entities.Service>("service_calendar_rules", null, value);
				this.OnPropertyChanged("service_calendar_rules");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public CalendarRule(object anonymousType) : 
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
                        Attributes["calendarruleid"] = base.Id;
                        break;
                    case "calendarruleid":
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
	}
}