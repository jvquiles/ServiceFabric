using Microsoft.ServiceFabric.Services.Communication.Runtime;
using Microsoft.ServiceFabric.Services.Runtime;
using System.Collections.Generic;
using System.Fabric;
using System.Threading;
using System.Threading.Tasks;

namespace AgentHub
{
    internal class AgentService: StatelessService
    {
        public AgentService(StatelessServiceContext context)
            : base(context)
        {
        }

        protected override IEnumerable<ServiceInstanceListener> CreateServiceInstanceListeners()
        {
            return base.CreateServiceInstanceListeners();
        }

        protected override Task RunAsync(CancellationToken cancellationToken)
        {
            return base.RunAsync(cancellationToken);
        }
    }
}