﻿using Microsoft.Xrm.Sdk;
using Source.DLaB.Xrm.Ioc;
using Source.DLaB.Xrm.Plugin;
using System.Collections.Generic;
using Xyz.Xrm.Entities;

namespace Xyz.Xrm.Plugin
{
    /// <summary>
    /// Showcases how to use an Assert Validator to enforce attributes are present
    /// </summary>
    public class ValidateEmailRouterApproval : PluginBase, IPlugin
    {
        #region Constructors

        public ValidateEmailRouterApproval(string unsecureConfig = null, string secureConfig = null) : base(unsecureConfig, secureConfig) { }
        public ValidateEmailRouterApproval(IIocContainer container, string unsecureConfig = null, string secureConfig = null) : base(unsecureConfig, secureConfig, container) { }

        #endregion Constructors

        protected override IEnumerable<RegisteredEvent> CreateEvents()
        {
            return new RegisteredEventBuilder(PipelineStage.PreOperation, MessageType.Create, MessageType.Update)
                .ForEntities<SystemUser>()
                .WithValidator(new RequirementValidator()
                    .Updated(new SystemUser { EmailRouterAccessApproval = SystemUser_EmailRouterAccessApproval.Approved }))

                .WithAssertValidator(new RequirementValidator()
                        .Contains<SystemUser>(ContextEntity.CoalesceTargetPreImage, u => new { u.FullName, u.MobilePhone }),
                    "Name and Mobile Phone are required to notify admin of email router access approval!")
                .Build();
        }

        protected override void ExecuteInternal(ExtendedPluginContext context)
        {
            context.Trace("Email Router Access Successfully Validated!");
        }
    }
}