using DLaB.Xrm;
using Xyz.Xrm.Entities;
using DLaB.Xrm.Test.Assumptions;
using Microsoft.Xrm.Sdk;

namespace Xyz.Xrm.Test.Assumptions
{
    // ReSharper disable once InconsistentNaming
    public class User_PowerAppsChecker : EntityDataAssumptionBaseAttribute, IAssumptionEntityType<User_PowerAppsChecker, SystemUser>
    {
        protected override Entity RetrieveEntity(IOrganizationService service)
        {
            return service.GetFirstOrDefault<SystemUser>(u => new
            {
                u.FullName,
                u.DomainName,
                u.ApplicationId,
            },
            SystemUser.Fields.ApplicationId, "c9299480-c13a-49db-a7ae-cdfe54fe0313");
        }
    }
}