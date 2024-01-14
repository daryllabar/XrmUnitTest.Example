using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Source.DLaB.Xrm.Ioc;

namespace Xyz.Xrm.Workflow
{
    public static class IocExtensions
    {
        public static IIocContainer RegisterWorkflowDefaults(this IIocContainer container)
        {
            return container;
        }
    }
}
