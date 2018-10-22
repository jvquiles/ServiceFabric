using System;
using System.Threading;
using Microsoft.ServiceFabric.Services.Runtime;

namespace AgentHub
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            try
            {
                ServiceRuntime.RegisterServiceAsync("AgentConversationApplication",
                    (statelessServiceContext) => new AgentService(statelessServiceContext)).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
            }

            Thread.Sleep(Timeout.Infinite);
        }
    }
}