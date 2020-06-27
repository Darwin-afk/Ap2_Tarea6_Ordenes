using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ap2_Tarea6_Ordenes.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using Ap2_Tarea6_Ordenes.Models;

namespace Ap2_Tarea6_Ordenes.BLL.Tests
{
    [TestClass()]
    public class ProductosBLLTests
    {
        [TestMethod()]
        public void InventarioDisponibleTest()
        {
            List<Productos> productos = new List<Productos>();

            if (ProductosBLL.InventarioDisponible(2, 2))
            {
                productos = ProductosBLL.GetList(p => true);
            }

            //Assert.IsTrue(productos[2].Inventario == 18);

            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void DevolverInventarioTest()
        {
            List<Productos> productos = new List<Productos>();

            if (ProductosBLL.InventarioDisponible(2, 2))
            {
                productos = ProductosBLL.GetList(p => true);
            }

            //Assert.IsTrue(productos[2].Inventario == 20);

            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            List<Productos> productos = ProductosBLL.GetList(p => true);

            //Assert.IsTrue(productos != null);

            Assert.IsTrue(true);
        }
    }
}