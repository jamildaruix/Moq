using Moq.Library.Interfaces;
using System.Threading.Tasks;

namespace Moq.Library.Repository
{
    public class FakeUoW : IFakeUoW
    {
        public async Task<bool> CommitAsync()
        {
            return true;
        }
    }
}
