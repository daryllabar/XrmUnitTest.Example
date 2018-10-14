﻿namespace Xyz.Xrm.Entities
{
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/dfnd/")]
    [Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("xyz_VoidPayment")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.2.1.8676")]
    public partial class xyz_VoidPaymentRequest : Microsoft.Xrm.Sdk.OrganizationRequest
    {
		
        public static class Fields
        {
            public const string PaymentId = "paymentId";
            public const string Amount = "amount";
        }
		
        public const string ActionLogicalName = "xyz_VoidPayment";
		
        public string PaymentId
        {
            get
            {
                if (this.Parameters.Contains("paymentId"))
                {
                    return ((string)(this.Parameters["paymentId"]));
                }
                else
                {
                    return default(string);
                }
            }
            set
            {
                this.Parameters["paymentId"] = value;
            }
        }
		
        public decimal Amount
        {
            get
            {
                if (this.Parameters.Contains("amount"))
                {
                    return ((decimal)(this.Parameters["amount"]));
                }
                else
                {
                    return default(decimal);
                }
            }
            set
            {
                this.Parameters["amount"] = value;
            }
        }
		
        public xyz_VoidPaymentRequest()
        {
            this.RequestName = "xyz_VoidPayment";
            this.PaymentId = default(string);
            this.Amount = default(decimal);
        }
    }
}
