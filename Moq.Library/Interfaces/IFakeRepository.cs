using Moq.Library.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Moq.Library.Interfaces
{
    public interface IFakeRepository
    {
        Task<Person> SelectPersonAsync();
        Task<IEnumerable<Person>> SearchAllAsync();
        Task<bool> RecordAsync();
    }
}
