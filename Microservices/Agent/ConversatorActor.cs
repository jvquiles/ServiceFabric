using Microsoft.ServiceFabric.Actors;
using Microsoft.ServiceFabric.Actors.Runtime;
using System.Threading.Tasks;

namespace Agent
{

    [ActorServiceAttribute(Name = "ConversatorActor")]
    [StatePersistence(StatePersistence.Volatile)]
    public class ConversatorActor : Actor, IConversatorActor
    {
        public ConversatorActor(ActorService actorService, ActorId actorId) : base(actorService, actorId)
        {
        }


        public Task<string> ListedAsync(string phrase)
        {
            return Task.FromResult($"{phrase} OK.");
        }
    }
}