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
	public enum Email_Notifications
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("None", 0)]
		None = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("The message was saved as a Microsoft Dynamics 365 email record, but not all the a" +
			"ttachments could be saved with it. An attachment cannot be saved if it is blocke" +
			"d or if its file type is invalid.", 1)]
		ThemessagewassavedasaMicrosoftDynamics365emailrecordbutnotalltheattachmentscouldbesavedwithitAnattachmentcannotbesavedifitisblockedorifitsfiletypeisinvalid = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Truncated body.", 2)]
		Truncatedbody = 2,
	}
}