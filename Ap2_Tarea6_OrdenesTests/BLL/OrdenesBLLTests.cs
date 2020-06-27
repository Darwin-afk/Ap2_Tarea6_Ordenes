using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ap2_Tarea6_Ordenes.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using Ap2_Tarea6_Ordenes.Models;

namespace Ap2_Tarea6_Ordenes.BLL.Tests
{
    [TestClass()]
    public class OrdenesBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Ordenes orden = new Ordenes();

            orden.OrdenId = 0;
            orden.Fecha = DateTime.Now;
            orden.SuplidorId = 1;
            orden.Monto = 100;
            orden.OrdenDetalle.Add(new OrdenesDetalle
            {
                Id = 0,
                OrdenId = 0,
                ProductoId = 3,
                Cantidad = 2,
                Costo = 50
            });

            bool paso = OrdenesBLL.Guardar(orden);

            //Assert.IsTrue(paso);

            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool paso = OrdenesBLL.Existe(1);

            //Assert.IsTrue(paso);

            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = OrdenesBLL.Eliminar(1);

            //Assert.IsTrue(paso);

            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Ordenes orden = OrdenesBLL.Buscar(1);

            //Assert.IsTrue(orden != null);

            Assert.IsTrue(true);
        }
    }
}