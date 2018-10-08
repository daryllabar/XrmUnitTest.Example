using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xyz.Xrm.Entities;
using Microsoft.Xrm.Sdk;
using Source.DLaB.Xrm;
using Source.DLaB.Xrm.Plugin;

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
            var sdkGetAddress = target.Contains(Contact.Fields.FirstName)
                ? target.FirstName
                : preImage.FirstName;

            var finalTarget = context.CoalesceTargetWithPreEntity<Contact>();
            var address = finalTarget.FirstName;

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
