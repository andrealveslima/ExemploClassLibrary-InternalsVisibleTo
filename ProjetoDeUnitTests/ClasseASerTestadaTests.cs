using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjetoDeUnitTests
{
    [TestClass]
    public class ClasseASerTestadaTests
    {
        [TestMethod]
        public void ClasseASerTestadaTest()
        {
            LibraryASerTestada.ClasseASerTestada instancia = new LibraryASerTestada.ClasseASerTestada();

            Assert.IsTrue(instancia.MetodoPublicoQueRetornaTrue());
            Assert.IsFalse(instancia.MetodoInternalQueRetornaFalse());
        }
    }
}
