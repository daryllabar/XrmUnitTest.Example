#pragma warning disable CS1591
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
	
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011//")]
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("Analyze")]
	public partial class AnalyzeRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string Version = "Version";
			public const string Target = "Target";
		}
		
		public const string ActionLogicalName = "Analyze";
		
		public string Version
		{
			get
			{
				if (this.Parameters.Contains("version"))
				{
					return ((string)(this.Parameters["version"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["version"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityReference Target
		{
			get
			{
				if (this.Parameters.Contains("Target"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["Target"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["Target"] = value;
			}
		}
		
		public AnalyzeRequest()
		{
			this.RequestName = "Analyze";
			this.Version = default(string);
			this.Target = default(Microsoft.Xrm.Sdk.EntityReference);
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011//")]
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("Analyze")]
	public partial class AnalyzeResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public static class Fields
		{
			public const string Response = "Response";
		}
		
		public const string ActionLogicalName = "Analyze";
		
		public AnalyzeResponse()
		{
		}
		
		public string Response
		{
			get
			{
				if (this.Results.Contains("response"))
				{
					return ((string)(this.Results["response"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Results["Response"] = value;
			}
		}
	}
}
#pragma warning restore CS1591
