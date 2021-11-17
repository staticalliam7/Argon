using System.Threading.Tasks;
using Coravel.Invocable;
using Main;

namespace Argon.Sceduler
{
    public class BlockJob : IInvocable
    {
        public Task Invoke()
        {
            Blockchain.BuildNewBlock();
            return Task.CompletedTask;
        }
    }
}