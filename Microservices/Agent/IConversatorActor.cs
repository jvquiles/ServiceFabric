using Microsoft.ServiceFabric.Actors;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Agent
{
    public interface IConversatorActor: IActor
    {
        Task<string> ListedAsync(string phrase);
    }
}