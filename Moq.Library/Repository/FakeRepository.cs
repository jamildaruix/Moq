using Moq.Library.Dto;
using Moq.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Moq.Library.Repository
{
    public class FakeRepository : IFakeRepository
    {
        public async Task<IEnumerable<Pessoa>> BuscarTodosAsync()
        {
            return new List<Pessoa>()
            {
                new Pessoa { Codigo = 1, Nome = "Jamil", Valor = 14.99M },
                new Pessoa { Codigo = 2, Nome = "Mariana", Valor = 99.99M },
                new Pessoa { Codigo = 3, Nome = "Davi", Valor = 3.89M },
            };
        }

        public async Task<bool> GravarAsync()
        {
            Pessoa p = new Pessoa { Nome = "Teste 1", Valor = 99M };
            return true;
        }

        public async Task<Pessoa> SelecionarPessoaAsync()
        {
            return new Pessoa() { Codigo = 1, Nome = "Jamil", Valor = 14.99M };
        }
    }
}