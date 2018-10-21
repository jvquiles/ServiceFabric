using Agent;
using Microsoft.ServiceFabric.Actors;
using Microsoft.ServiceFabric.Actors.Client;
using System;

namespace AgentFeeder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AgentConversation agentConversationProxy = ActorProxy.Create<AgentConversation>(new ActorId(0x101), "fabric:/CounterActorApplication", "CounterActor");
            string result = agentConversationProxy.ListedAsync("Hello").Result;
        }
    }
}