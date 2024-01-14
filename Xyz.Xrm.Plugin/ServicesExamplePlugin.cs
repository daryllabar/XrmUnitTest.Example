using Source.DLaB.Xrm;
using Source.DLaB.Xrm.Ioc;
using Source.DLaB.Xrm.Plugin;
using System.Collections.Generic;
using System.Linq;
using Xyz.Xrm.Entities;

namespace Xyz.Xrm.Plugin
{
    /// <summary>
    /// Just an example of how to utilize the IOC for plugins
    /// </summary>
    public class ServicesExamplePlugin : PluginBase
    {
        protected override IEnumerable<RegisteredEvent> CreateEvents()
        {
            return new RegisteredEventBuilder(PipelineStage.PreOperation, MessageType.Update).
                ForEntities(Contact.EntityLogicalName).Build();
        }

        #region Constructors
        public ServicesExamplePlugin(string unsecureConfig = null, string secureConfig = null) : base(unsecureConfig, secureConfig) { }
        public ServicesExamplePlugin(IIocContainer container, string unsecureConfig = null, string secureConfig = null) : base(unsecureConfig, secureConfig, container)
        {
        }

        #endregion Constructors

        protected override IIocContainer RegisterServices(IIocContainer container)
        {
            return base.RegisterServices(container)
                .AddScoped<IServicesExampleData, DataLogicImplementation>();
        }

        protected override void ExecuteInternal(ExtendedPluginContext context)
        {
            var data = context.ServiceProvider.GetService<IServicesExampleData>();
            var contact = context.CoalesceTargetWithPreEntity<Contact>();
            var dependents = data.GetDependents(contact.LastName);
            data.SyncAndUpdateAddresses(contact, dependents);
        }
    }

    public interface IServicesExampleData {
        List<Contact> GetDependents(string lastName);
        void SyncAndUpdateAddresses(Contact main, List<Contact> dependents);
    }

    public class DataLogicImplementation : IServicesExampleData {
        private readonly ExtendedPluginContext _context;
        public DataLogicImplementation(ExtendedPluginContext context)
        {
            _context = context;
        }

        public List<Contact> GetDependents(string lastName)
        {
            return _context.SystemOrganizationService.GetEntities<Contact>(Contact.Fields.LastName, lastName).ToList();
        }

        public void SyncAndUpdateAddresses(Contact main, List<Contact> dependents)
        {
            foreach(var dependent in dependents)
            {
                _context.OrganizationService.Update(new Contact{
                    Address1_City = main.Address1_City,
                    Address1_Line1 = main.Address1_Line1,
                    Address1_Line2 = main.Address1_Line2,
                    Address1_PostalCode = main.Address1_PostalCode,
                    Address1_StateOrProvince = main.Address1_StateOrProvince,
                    Id = dependent.Id
                });
            }
        }
    }
}
