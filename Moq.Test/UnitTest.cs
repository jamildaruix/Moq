using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq.Library.Dto;
using Moq.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Moq.Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Record()
        {
            var mockRepository = new Mock<IFakeRepository>();

            mockRepository.Setup(s => s.RecordAsync())
                          .ReturnsAsync(false);

            Assert.AreEqual(mockRepository.Object.RecordAsync(), true);
        }

        [TestMethod]
        public void FilterOne()
        {
            Person p = new Person() { Code = 1,  Name = "Jamil", Money = 1.99M };

            var mockRepository = new Mock<IFakeRepository>();

            mockRepository.Setup(s => s.SelectPersonAsync())
                           .ReturnsAsync(p);

            var obj = mockRepository.Object.SelectPersonAsync().GetAwaiter().GetResult();

            Assert.AreEqual(obj.Code, 1);
        }

        [TestMethod]
        public void Filter()
        {
            IEnumerable<Person> list = new List<Person>()
            {
                new Person { Code = 1, Name = "Jamil", Money = 2.99M },
                new Person { Code = 2, Name = "Mariana", Money = 90M },
                new Person { Code = 3, Name = "Davi", Money = 44.99M },
            };

            var mockRepository = new Mock<IFakeRepository>();

            mockRepository.Setup(s => s.SearchAllAsync())
                           .ReturnsAsync(list);

            var obj = mockRepository.Object.SearchAllAsync().GetAwaiter().GetResult();

            Assert.AreEqual(obj.Where(w => w.Code == 3).Select(s => s.Name).SingleOrDefault() , "Davi");
        }
    }
}