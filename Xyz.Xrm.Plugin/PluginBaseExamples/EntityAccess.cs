using System.Collections.Generic;
using Xyz.Xrm.Entities;
using Microsoft.Xrm.Sdk;
using Source.DLaB.Xrm.Plugin;
// ReSharper disable UnusedVariable, RedundantExtendsListEntry

namespace Xyz.Xrm.Plugin.PluginBaseExamples
{

    /// <summary>
    /// Shows hows the to get Entities from Context including final value from target/pre-image
    /// </summary>
    public class EntityAccess : PluginBase, IPlugin
    {
        protected override void ExecuteInternal(ExtendedPluginContext context)
        {
            var sdkWay = ((Entity) context.InputParameters["Target"]).ToEntity<Contact>();
            var target = context.GetTarget<Contact>();

            var preImage = context.GetPreEntity<Contact>();
            var sdkGetFirstName = target.Contains(Contact.Fields.FirstName)
                ? target.FirstName
                : preImage.FirstName;

            var finalTarget = context.CoalesceTargetWithPreEntity<Contact>();
            var firstName = finalTarget.FirstName;                                                                        

            /***************************
		     *    Plugin Logic Here    *
		     ***************************/
        }
        
        #region Constructors

        public EntityAccess() : this(null, null) { }
        public EntityAccess(string unsecureConfig, string secureConfig) : base(unsecureConfig, secureConfig) { }

        #endregion Constructors

        protected override IEnumerable<RegisteredEvent> CreateEvents()
        {
            return new RegisteredEventBuilder(PipelineStage.PreOperation, MessageType.Update)
                .ForEntities(Contact.EntityLogicalName).Build();
        }
    }
}
