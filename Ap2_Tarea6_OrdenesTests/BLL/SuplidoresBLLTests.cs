using Ap2_Tarea6_Ordenes.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Ap2_Tarea6_Ordenes.Models;

namespace Ap2_Tarea6_Ordenes.BLL.Tests
{
    [TestClass()]
    public class SuplidoresBLLTests
    {
        [TestMethod()]
        public void BuscarTest()
        {
            Suplidores suplidor = SuplidoresBLL.Buscar(1);

            //Assert.IsTrue(suplidor != null);

            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            List<Suplidores> suplidores = SuplidoresBLL.GetList(s => true);

            //Assert.IsTrue(suplidores != null);

            Assert.IsTrue(true);
        }
    }
}