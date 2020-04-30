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
	/// Note that is attached to one or more objects, including other notes.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("annotation")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.1.0.42")]
	public partial class Annotation : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string AnnotationId = "annotationid";
			public const string Id = "annotationid";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string DocumentBody = "documentbody";
			public const string FileName = "filename";
			public const string FileSize = "filesize";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string IsDocument = "isdocument";
			public const string LangId = "langid";
			public const string MimeType = "mimetype";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string NoteText = "notetext";
			public const string ObjectId = "objectid";
			public const string ObjectTypeCode = "objecttypecode";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningTeam = "owningteam";
			public const string OwningUser = "owninguser";
			public const string Prefix = "prefix";
			public const string StepId = "stepid";
			public const string Subject = "subject";
			public const string VersionNumber = "versionnumber";
			public const string Account_Annotation = "Account_Annotation";
			public const string annotation_owning_user = "annotation_owning_user";
			public const string Appointment_Annotation = "Appointment_Annotation";
			public const string business_unit_annotations = "business_unit_annotations";
			public const string Competitor_Annotation = "Competitor_Annotation";
			public const string Contact_Annotation = "Contact_Annotation";
			public const string Email_Annotation = "Email_Annotation";
			public const string Incident_Annotation = "Incident_Annotation";
			public const string Lead_Annotation = "Lead_Annotation";
			public const string lk_annotationbase_createdby = "lk_annotationbase_createdby";
			public const string lk_annotationbase_createdonbehalfby = "lk_annotationbase_createdonbehalfby";
			public const string lk_annotationbase_modifiedby = "lk_annotationbase_modifiedby";
			public const string lk_annotationbase_modifiedonbehalfby = "lk_annotationbase_modifiedonbehalfby";
			public const string msdyn_processnotes_Annotations = "msdyn_processnotes_Annotations";
			public const string Opportunity_Annotation = "Opportunity_Annotation";
			public const string OpportunityClose_Annotation = "OpportunityClose_Annotation";
			public const string OrderClose_Annotation = "OrderClose_Annotation";
			public const string PhoneCall_Annotation = "PhoneCall_Annotation";
			public const string Product_Annotation = "Product_Annotation";
			public const string SalesOrder_Annotation = "SalesOrder_Annotation";
			public const string Task_Annotation = "Task_Annotation";
			public const string team_annotations = "team_annotations";
			public const string Workflow_Annotation = "Workflow_Annotation";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public Annotation() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "annotation";
		
		public const string EntitySchemaName = "Annotation";
		
		public const string PrimaryIdAttribute = "annotationid";
		
		public const string PrimaryNameAttribute = "subject";
		
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
		/// Unique identifier of the note.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("annotationid")]
		public System.Nullable<System.Guid> AnnotationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("annotationid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AnnotationId");
				this.SetAttributeValue("annotationid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("AnnotationId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("annotationid")]
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
				this.AnnotationId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the note.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the note was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the annotation.
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
		/// Contents of the note's attachment.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("documentbody")]
		public string DocumentBody
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("documentbody");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DocumentBody");
				this.SetAttributeValue("documentbody", value);
				this.OnPropertyChanged("DocumentBody");
			}
		}
		
		/// <summary>
		/// File name of the note.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("filename")]
		public string FileName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("filename");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FileName");
				this.SetAttributeValue("filename", value);
				this.OnPropertyChanged("FileName");
			}
		}
		
		/// <summary>
		/// File size of the note.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("filesize")]
		public System.Nullable<int> FileSize
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("filesize");
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
		/// Specifies whether the note is an attachment.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdocument")]
		public System.Nullable<bool> IsDocument
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isdocument");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsDocument");
				this.SetAttributeValue("isdocument", value);
				this.OnPropertyChanged("IsDocument");
			}
		}
		
		/// <summary>
		/// Language identifier for the note.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("langid")]
		public string LangId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("langid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("LangId");
				this.SetAttributeValue("langid", value);
				this.OnPropertyChanged("LangId");
			}
		}
		
		/// <summary>
		/// MIME type of the note's attachment.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mimetype")]
		public string MimeType
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("mimetype");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("MimeType");
				this.SetAttributeValue("mimetype", value);
				this.OnPropertyChanged("MimeType");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the note.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the note was last modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the annotation.
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
		/// Text of the note.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("notetext")]
		public string NoteText
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("notetext");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("NoteText");
				this.SetAttributeValue("notetext", value);
				this.OnPropertyChanged("NoteText");
			}
		}
		
		/// <summary>
		/// Unique identifier of the object with which the note is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
		public Microsoft.Xrm.Sdk.EntityReference ObjectId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("objectid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ObjectId");
				this.SetAttributeValue("objectid", value);
				this.OnPropertyChanged("ObjectId");
			}
		}
		
		/// <summary>
		/// Type of entity with which the note is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objecttypecode")]
		public string ObjectTypeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("objecttypecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ObjectTypeCode");
				this.SetAttributeValue("objecttypecode", value);
				this.OnPropertyChanged("ObjectTypeCode");
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
		/// Unique identifier of the user or team who owns the note.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OwnerId");
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("OwnerId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the business unit that owns the note.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
		}
		
		/// <summary>
		/// Unique identifier of the team who owns the note.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who owns the note.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
		}
		
		/// <summary>
		/// Prefix of the file pointer in blob storage.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("prefix")]
		public string Prefix
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("prefix");
			}
		}
		
		/// <summary>
		/// workflow step id associated with the note.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stepid")]
		public string StepId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("stepid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StepId");
				this.SetAttributeValue("stepid", value);
				this.OnPropertyChanged("StepId");
			}
		}
		
		/// <summary>
		/// Subject associated with the note.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subject")]
		public string Subject
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("subject");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Subject");
				this.SetAttributeValue("subject", value);
				this.OnPropertyChanged("Subject");
			}
		}
		
		/// <summary>
		/// Version number of the note.
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
		/// 1:N Annotation_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Annotation_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<Xyz.Xrm.Entities.AsyncOperation> Annotation_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Xyz.Xrm.Entities.AsyncOperation>("Annotation_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Annotation_AsyncOperations");
				this.SetRelatedEntities<Xyz.Xrm.Entities.AsyncOperation>("Annotation_AsyncOperations", null, value);
				this.OnPropertyChanged("Annotation_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N Annotation_ProcessSessions
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Annotation_ProcessSessions")]
		public System.Collections.Generic.IEnumerable<Xyz.Xrm.Entities.ProcessSession> Annotation_ProcessSessions
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Xyz.Xrm.Entities.ProcessSession>("Annotation_ProcessSessions", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Annotation_ProcessSessions");
				this.SetRelatedEntities<Xyz.Xrm.Entities.ProcessSession>("Annotation_ProcessSessions", null, value);
				this.OnPropertyChanged("Annotation_ProcessSessions");
			}
		}
		
		/// <summary>
		/// N:1 Account_Annotation
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_Annotation")]
		public Xyz.Xrm.Entities.Account Account_Annotation
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.Account>("Account_Annotation", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Account_Annotation");
				this.SetRelatedEntity<Xyz.Xrm.Entities.Account>("Account_Annotation", null, value);
				this.OnPropertyChanged("Account_Annotation");
			}
		}
		
		/// <summary>
		/// N:1 annotation_owning_user
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("annotation_owning_user")]
		public Xyz.Xrm.Entities.SystemUser annotation_owning_user
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.SystemUser>("annotation_owning_user", null);
			}
		}
		
		/// <summary>
		/// N:1 Appointment_Annotation
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Appointment_Annotation")]
		public Xyz.Xrm.Entities.Appointment Appointment_Annotation
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.Appointment>("Appointment_Annotation", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Appointment_Annotation");
				this.SetRelatedEntity<Xyz.Xrm.Entities.Appointment>("Appointment_Annotation", null, value);
				this.OnPropertyChanged("Appointment_Annotation");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_annotations
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_annotations")]
		public Xyz.Xrm.Entities.BusinessUnit business_unit_annotations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.BusinessUnit>("business_unit_annotations", null);
			}
		}
		
		/// <summary>
		/// N:1 Competitor_Annotation
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Competitor_Annotation")]
		public Xyz.Xrm.Entities.Competitor Competitor_Annotation
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.Competitor>("Competitor_Annotation", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Competitor_Annotation");
				this.SetRelatedEntity<Xyz.Xrm.Entities.Competitor>("Competitor_Annotation", null, value);
				this.OnPropertyChanged("Competitor_Annotation");
			}
		}
		
		/// <summary>
		/// N:1 Contact_Annotation
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contact_Annotation")]
		public Xyz.Xrm.Entities.Contact Contact_Annotation
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.Contact>("Contact_Annotation", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Contact_Annotation");
				this.SetRelatedEntity<Xyz.Xrm.Entities.Contact>("Contact_Annotation", null, value);
				this.OnPropertyChanged("Contact_Annotation");
			}
		}
		
		/// <summary>
		/// N:1 Email_Annotation
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Email_Annotation")]
		public Xyz.Xrm.Entities.Email Email_Annotation
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.Email>("Email_Annotation", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Email_Annotation");
				this.SetRelatedEntity<Xyz.Xrm.Entities.Email>("Email_Annotation", null, value);
				this.OnPropertyChanged("Email_Annotation");
			}
		}
		
		/// <summary>
		/// N:1 Incident_Annotation
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_Annotation")]
		public Xyz.Xrm.Entities.Incident Incident_Annotation
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.Incident>("Incident_Annotation", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Incident_Annotation");
				this.SetRelatedEntity<Xyz.Xrm.Entities.Incident>("Incident_Annotation", null, value);
				this.OnPropertyChanged("Incident_Annotation");
			}
		}
		
		/// <summary>
		/// N:1 Lead_Annotation
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_Annotation")]
		public Xyz.Xrm.Entities.Lead Lead_Annotation
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.Lead>("Lead_Annotation", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Lead_Annotation");
				this.SetRelatedEntity<Xyz.Xrm.Entities.Lead>("Lead_Annotation", null, value);
				this.OnPropertyChanged("Lead_Annotation");
			}
		}
		
		/// <summary>
		/// N:1 lk_annotationbase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annotationbase_createdby")]
		public Xyz.Xrm.Entities.SystemUser lk_annotationbase_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.SystemUser>("lk_annotationbase_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_annotationbase_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annotationbase_createdonbehalfby")]
		public Xyz.Xrm.Entities.SystemUser lk_annotationbase_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.SystemUser>("lk_annotationbase_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_annotationbase_createdonbehalfby");
				this.SetRelatedEntity<Xyz.Xrm.Entities.SystemUser>("lk_annotationbase_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_annotationbase_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_annotationbase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annotationbase_modifiedby")]
		public Xyz.Xrm.Entities.SystemUser lk_annotationbase_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.SystemUser>("lk_annotationbase_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_annotationbase_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annotationbase_modifiedonbehalfby")]
		public Xyz.Xrm.Entities.SystemUser lk_annotationbase_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.SystemUser>("lk_annotationbase_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_annotationbase_modifiedonbehalfby");
				this.SetRelatedEntity<Xyz.Xrm.Entities.SystemUser>("lk_annotationbase_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_annotationbase_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 msdyn_processnotes_Annotations
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_processnotes_Annotations")]
		public Xyz.Xrm.Entities.msdyn_processnotes msdyn_processnotes_Annotations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.msdyn_processnotes>("msdyn_processnotes_Annotations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_processnotes_Annotations");
				this.SetRelatedEntity<Xyz.Xrm.Entities.msdyn_processnotes>("msdyn_processnotes_Annotations", null, value);
				this.OnPropertyChanged("msdyn_processnotes_Annotations");
			}
		}
		
		/// <summary>
		/// N:1 Opportunity_Annotation
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_Annotation")]
		public Xyz.Xrm.Entities.Opportunity Opportunity_Annotation
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.Opportunity>("Opportunity_Annotation", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Opportunity_Annotation");
				this.SetRelatedEntity<Xyz.Xrm.Entities.Opportunity>("Opportunity_Annotation", null, value);
				this.OnPropertyChanged("Opportunity_Annotation");
			}
		}
		
		/// <summary>
		/// N:1 OpportunityClose_Annotation
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("OpportunityClose_Annotation")]
		public Xyz.Xrm.Entities.OpportunityClose OpportunityClose_Annotation
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.OpportunityClose>("OpportunityClose_Annotation", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OpportunityClose_Annotation");
				this.SetRelatedEntity<Xyz.Xrm.Entities.OpportunityClose>("OpportunityClose_Annotation", null, value);
				this.OnPropertyChanged("OpportunityClose_Annotation");
			}
		}
		
		/// <summary>
		/// N:1 OrderClose_Annotation
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("OrderClose_Annotation")]
		public Xyz.Xrm.Entities.OrderClose OrderClose_Annotation
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.OrderClose>("OrderClose_Annotation", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OrderClose_Annotation");
				this.SetRelatedEntity<Xyz.Xrm.Entities.OrderClose>("OrderClose_Annotation", null, value);
				this.OnPropertyChanged("OrderClose_Annotation");
			}
		}
		
		/// <summary>
		/// N:1 PhoneCall_Annotation
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("PhoneCall_Annotation")]
		public Xyz.Xrm.Entities.PhoneCall PhoneCall_Annotation
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.PhoneCall>("PhoneCall_Annotation", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PhoneCall_Annotation");
				this.SetRelatedEntity<Xyz.Xrm.Entities.PhoneCall>("PhoneCall_Annotation", null, value);
				this.OnPropertyChanged("PhoneCall_Annotation");
			}
		}
		
		/// <summary>
		/// N:1 Product_Annotation
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Product_Annotation")]
		public Xyz.Xrm.Entities.Product Product_Annotation
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.Product>("Product_Annotation", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Product_Annotation");
				this.SetRelatedEntity<Xyz.Xrm.Entities.Product>("Product_Annotation", null, value);
				this.OnPropertyChanged("Product_Annotation");
			}
		}
		
		/// <summary>
		/// N:1 SalesOrder_Annotation
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrder_Annotation")]
		public Xyz.Xrm.Entities.SalesOrder SalesOrder_Annotation
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.SalesOrder>("SalesOrder_Annotation", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SalesOrder_Annotation");
				this.SetRelatedEntity<Xyz.Xrm.Entities.SalesOrder>("SalesOrder_Annotation", null, value);
				this.OnPropertyChanged("SalesOrder_Annotation");
			}
		}
		
		/// <summary>
		/// N:1 Task_Annotation
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Task_Annotation")]
		public Xyz.Xrm.Entities.Task Task_Annotation
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.Task>("Task_Annotation", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Task_Annotation");
				this.SetRelatedEntity<Xyz.Xrm.Entities.Task>("Task_Annotation", null, value);
				this.OnPropertyChanged("Task_Annotation");
			}
		}
		
		/// <summary>
		/// N:1 team_annotations
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_annotations")]
		public Xyz.Xrm.Entities.Team team_annotations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.Team>("team_annotations", null);
			}
		}
		
		/// <summary>
		/// N:1 Workflow_Annotation
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Workflow_Annotation")]
		public Xyz.Xrm.Entities.Workflow Workflow_Annotation
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xyz.Xrm.Entities.Workflow>("Workflow_Annotation", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Workflow_Annotation");
				this.SetRelatedEntity<Xyz.Xrm.Entities.Workflow>("Workflow_Annotation", null, value);
				this.OnPropertyChanged("Workflow_Annotation");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public Annotation(object anonymousType) : 
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
                        Attributes["annotationid"] = base.Id;
                        break;
                    case "annotationid":
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