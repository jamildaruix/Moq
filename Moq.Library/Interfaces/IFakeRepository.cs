using Moq.Library.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Moq.Library.Interfaces
{
    public interface IFakeRepository
    {
        Task<Pessoa> SelecionarPessoaAsync();
        Task<IEnumerable<Pessoa>> BuscarTodosAsync();
        Task<bool> GravarAsync();
    }
}
