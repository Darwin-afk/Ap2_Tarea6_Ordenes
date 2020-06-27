using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ap2_Tarea6_Ordenes.Models;
using Ap2_Tarea6_Ordenes.DAL;

namespace Ap2_Tarea6_Ordenes.BLL
{
    public class OrdenesBLL
    {
        public static bool Guardar(Ordenes orden)
        {
            if (!Existe(orden.OrdenId))
                return Insertar(orden);
            else
                return Modificar(orden);
        }

        public static bool Existe(int id)
        {
            bool encontrado = false;
            Contexto contexto = new Contexto();

            try
            {
                encontrado = contexto.Ordenes.Any(o => o.OrdenId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }

        private static bool Insertar(Ordenes orden)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Ordenes.Add(orden);
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

        private static bool Modificar(Ordenes orden)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Database.ExecuteSqlRaw($"Delete FROM OrdenesDetalle Where OrdenId={orden.OrdenId}");
                foreach(var item in orden.OrdenDetalle)
                {
                    contexto.Entry(item).State = EntityState.Added;
                }

                contexto.Entry(orden).State = EntityState.Modified;
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

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var orden = Buscar(id);

                foreach(var item in orden.OrdenDetalle)
                {
                    ProductosBLL.DevolverInventario(item.ProductoId, item.Cantidad);
                }

                contexto.Ordenes.Remove(orden);

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

        public static Ordenes Buscar(int id)
        {
            Ordenes orden = new Ordenes();
            Contexto contexto = new Contexto();

            try
            {
                orden = contexto.Ordenes
                    .Where(o => o.OrdenId == id)
                    .Include(o => o.OrdenDetalle)
                    .FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return orden;
        }
    }
}
