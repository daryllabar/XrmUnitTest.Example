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
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.1.0.42")]
	public enum ProcessStage_OperationType
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("ApiApp", 1, "#0000ff")]
		ApiApp = 473330001,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("ApiConnection", 6, "#0000ff")]
		ApiConnection = 473330006,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("ApiConnectionNotification", 50, "#0000ff")]
		ApiConnectionNotification = 473330050,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("ApiConnectionWebhook", 9, "#0000ff")]
		ApiConnectionWebhook = 473330009,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("ApiManagement", 16, "#0000ff")]
		ApiManagement = 473330016,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("AppendToArrayVariable", 37, "#0000ff")]
		AppendToArrayVariable = 473330037,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("AppendToStringVariable", 38, "#0000ff")]
		AppendToStringVariable = 473330038,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("As2Decode", 45, "#0000ff")]
		As2Decode = 473330045,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("As2Encode", 46, "#0000ff")]
		As2Encode = 473330046,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Batch", 39, "#0000ff")]
		Batch = 473330039,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Changeset", 51, "#0000ff")]
		Changeset = 473330051,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Compose", 13, "#0000ff")]
		Compose = 473330013,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("DecrementVariable", 35, "#0000ff")]
		DecrementVariable = 473330035,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Expression", 42, "#0000ff")]
		Expression = 473330042,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("FlatFileDecoding", 25, "#0000ff")]
		FlatFileDecoding = 473330025,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("FlatFileEncoding", 18, "#0000ff")]
		FlatFileEncoding = 473330018,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Flow", 4, "#0000ff")]
		Flow = 473330004,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Foreach", 22, "#0000ff")]
		Foreach = 473330022,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Function", 15, "#0000ff")]
		Function = 473330015,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Http", 0, "#0000ff")]
		Http = 473330000,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("HttpWebhook", 12, "#0000ff")]
		HttpWebhook = 473330012,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("If", 21, "#0000ff")]
		If = 473330021,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("IncrementVariable", 34, "#0000ff")]
		IncrementVariable = 473330034,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("InitializeVariable", 33, "#0000ff")]
		InitializeVariable = 473330033,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("IntegrationAccountArtifactLookup", 27, "#0000ff")]
		IntegrationAccountArtifactLookup = 473330027,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("JavascriptCode", 44, "#0000ff")]
		JavascriptCode = 473330044,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Join", 31, "#0000ff")]
		Join = 473330031,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Liquid", 43, "#0000ff")]
		Liquid = 473330043,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Manual", 8, "#0000ff")]
		Manual = 473330008,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("OpenApiConnection", 7, "#0000ff")]
		OpenApiConnection = 473330007,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("OpenApiConnectionWebhook", 10, "#0000ff")]
		OpenApiConnectionWebhook = 473330010,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("ParseJson", 29, "#0000ff")]
		ParseJson = 473330029,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Query", 14, "#0000ff")]
		Query = 473330014,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Recurrence", 2, "#0000ff")]
		Recurrence = 473330002,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Request", 20, "#0000ff")]
		Request = 473330020,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Response", 11, "#0000ff")]
		Response = 473330011,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("RosettaNetDecode", 48, "#0000ff")]
		RosettaNetDecode = 473330048,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("RosettaNetEncode", 47, "#0000ff")]
		RosettaNetEncode = 473330047,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("RosettaNetWaitForResponse", 49, "#0000ff")]
		RosettaNetWaitForResponse = 473330049,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Scope", 19, "#0000ff")]
		Scope = 473330019,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Select", 32, "#0000ff")]
		Select = 473330032,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("SendToBatch", 40, "#0000ff")]
		SendToBatch = 473330040,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("SetVariable", 36, "#0000ff")]
		SetVariable = 473330036,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("SlidingWindow", 41, "#0000ff")]
		SlidingWindow = 473330041,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("SwiftEncode", 52, "#0000ff")]
		SwiftEncode = 473330052,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Switch", 28, "#0000ff")]
		Switch = 473330028,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Table", 30, "#0000ff")]
		Table = 473330030,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Terminate", 26, "#0000ff")]
		Terminate = 473330026,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Until", 23, "#0000ff")]
		Until = 473330023,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Wait", 5, "#0000ff")]
		Wait = 473330005,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Workflow", 3, "#0000ff")]
		Workflow = 473330003,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("XmlValidation", 17, "#0000ff")]
		XmlValidation = 473330017,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Xslt", 24, "#0000ff")]
		Xslt = 473330024,
	}
}