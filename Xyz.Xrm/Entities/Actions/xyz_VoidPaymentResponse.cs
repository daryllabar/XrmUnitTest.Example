namespace Xyz.Xrm.Entities
{
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/xyz")]
    [Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("xyz_VoidPayment")]
    public partial class xyz_VoidPaymentResponse : Microsoft.Xrm.Sdk.OrganizationResponse
    {
		
        public static class Fields
        {
            public const string Message = "message";
            public const string PaymentVoided = "paymentVoided";
        }
		
        public const string ActionLogicalName = "xyz_VoidPayment";
		
        public xyz_VoidPaymentResponse()
        {
        }
		
        public string Message
        {
            get
            {
                if (this.Results.Contains("message"))
                {
                    return ((string)(this.Results["message"]));
                }
                else
                {
                    return default(string);
                }
            }
            set
            {
                this.Results["message"] = value;
            }
        }
		
        public bool PaymentVoided
        {
            get
            {
                if (this.Results.Contains("paymentVoided"))
                {
                    return ((bool)(this.Results["paymentVoided"]));
                }
                else
                {
                    return default(bool);
                }
            }
            set
            {
                this.Results["paymentVoided"] = value;
            }
        }
    }
}