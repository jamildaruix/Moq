using System.Threading.Tasks;

namespace Moq.Library.Interfaces
{
    public interface IFakeUoW
    {
       Task<bool> CommitAsync();
    }
}
