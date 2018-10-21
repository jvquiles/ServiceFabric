using Microsoft.ServiceFabric.Actors.Runtime;
using System;
using System.Threading;

namespace Agent
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            try
            {
                ActorRuntime.RegisterActorAsync<AgentConversation>(
                   (context, actorType) => new ActorService(context, actorType)).GetAwaiter().GetResult();

                Thread.Sleep(Timeout.Infinite);
            }
            catch (Exception ex)
            {
            }
        }
    }
}