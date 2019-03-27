using Moq.Library.Dto;
using Moq.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Moq.Library.Repository
{
    public class FakeRepository : IFakeRepository
    {
        public async Task<IEnumerable<Person>> SearchAllAsync()
        {
            return new List<Person>()
            {
                new Person { Code = 1, Name = "Jamil", Money = 14.99M },
                new Person { Code = 2, Name = "Mariana", Money = 99.99M },
                new Person { Code = 3, Name = "Davi", Money = 3.89M },
            };
        }

        public async Task<bool> RecordAsync()
        {
            Person p = new Person { Name = "Value 1", Money = 99M };
            return true;
        }

        public async Task<Person> SelectPersonAsync()
        {
            return new Person() { Code = 1, Name = "Jamil", Money = 14.99M };
        }
    }
}