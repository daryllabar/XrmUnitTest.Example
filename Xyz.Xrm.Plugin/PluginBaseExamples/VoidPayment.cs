using System.Collections.Generic;
using Source.DLaB.Xrm.Plugin;
using Microsoft.Xrm.Sdk;
using Xyz.Xrm.Entities;
// ReSharper disable UnusedMember.Global

namespace Xyz.Xrm.Plugin.PluginBaseExamples
{

    /// <summary>
    /// Example Plugin Class for a Custom Action.
    /// </summary>
    public class VoidPayment : ActionPluginBase<xyz_VoidPaymentRequest, xyz_VoidPaymentResponse>, IPlugin
    {
        protected override void ExecuteInternal(ActionContext<xyz_VoidPaymentRequest, xyz_VoidPaymentResponse> context)
        {
            if (context.Request.Amount > 100)
            {
                context.Response.PaymentVoided = false;
                context.Response.Message = "Amount is too large.";
                return;
            }

            /**************************************
             *    Plugin Logic to Void Payment    *
             **************************************/

            context.Response.PaymentVoided = true;
        }

        // ReSharper disable once InconsistentNaming
        public static MessageType xyz_VoidPayment = new MessageType(xyz_VoidPaymentResponse.ActionLogicalName);

        #region Constructors

        public VoidPayment() : this(null, null) { }
        public VoidPayment(string unsecureConfig, string secureConfig) : base(unsecureConfig, secureConfig) { }

        #endregion Constructors

        protected override IEnumerable<RegisteredEvent> CreateEvents()
        {
            return new RegisteredEventBuilder(PipelineStage.PreOperation, xyz_VoidPayment).Build();
        }
    }
}
