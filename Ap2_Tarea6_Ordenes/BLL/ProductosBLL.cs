using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ap2_Tarea6_Ordenes.Models;
using Ap2_Tarea6_Ordenes.DAL;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Ap2_Tarea6_Ordenes.BLL
{
    public class ProductosBLL
    {
        public static bool InventarioDisponible(int productoId, int cantidad)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                Productos producto = contexto.Productos.Find(productoId);

                if (producto.Inventario > cantidad)
                {
                    producto.Inventario -= cantidad;
                    Modificar(producto);
                    paso = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static void DevolverInventario(int productoId, int cantidad)
        {
            Contexto contexto = new Contexto();

            try
            {
                Productos producto = contexto.Productos.Find(productoId);
                producto.Inventario += cantidad;
                Modificar(producto);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
        }

        private static bool Modificar(Productos producto)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(producto).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static List<Productos> GetList(Expression<Func<Productos, bool>> criterio)
        {
            List<Productos> lista = new List<Productos>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Productos.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }
    }
}
