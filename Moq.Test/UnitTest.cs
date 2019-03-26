using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq.Library.Dto;
using Moq.Library.Interfaces;
using System.Collections.Generic;

namespace Moq.Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Gravar()
        {
            var mockRepository = new Mock<IFakeRepository>() {  CallBase = true};
            var mockUoW = new Mock<IFakeUoW>();

            mockRepository.Setup(s => s.GravarAsync()).ReturnsAsync(true);

            var teste = mockRepository.Object;
            var returns = teste.GravarAsync().GetAwaiter().GetResult();

            mockRepository.VerifyAll();

            Assert.AreEqual(returns, true);
        }

        [TestMethod]
        public void BuscarUm()
        {
            Pessoa p = new Pessoa() { Nome = "Jamil", Valor = 1.99M };

            var mockRepository = new Mock<IFakeRepository>() { CallBase = true };

            mockRepository.Setup(s => s.SelecionarPessoaAsync().ReturnsAsync(p);

            var teste = mockRepository.Object;
            var returns = teste.SelecionarPessoaAsync().GetAwaiter().GetResult();

            mockRepository.VerifyAll();

            Assert.AreEqual(returns, true);
        }
    }
}
