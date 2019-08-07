using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Source.DLaB.Xrm.Plugin;
using Microsoft.Xrm.Sdk;
using Xyz.Xrm.Entities;
// ReSharper disable UnusedMember.Global

namespace Xyz.Xrm.Plugin.PluginBaseExamples
{

    /// <summary>
    /// Example Plugin Class for a Custom Action.
    /// </summary>
    [SuppressMessage("ReSharper", "RedundantExtendsListEntry")]
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

        public VoidPayment(string unsecureConfig = null, string secureConfig = null) : base(unsecureConfig, secureConfig) { }

        #endregion Constructors

        protected override IEnumerable<RegisteredEvent> CreateEvents()
        {
            return new RegisteredEventBuilder(PipelineStage.PreOperation, xyz_VoidPayment).Build();
        }
    }
}
