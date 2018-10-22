using Microsoft.ServiceFabric.Actors;
using Microsoft.ServiceFabric.Actors.Runtime;
using System.Threading.Tasks;

namespace Agent
{

    [ActorServiceAttribute(Name = "AgentConversation")]
    [StatePersistence(StatePersistence.Volatile)]
    public class AgentConversation : Actor, IActor
    {
        public AgentConversation(ActorService actorService, ActorId actorId) : base(actorService, actorId)
        {
        }


        public Task<string> ListedAsync(string phrase)
        {
            return Task.FromResult($"{phrase} OK.");
        }
    }
}