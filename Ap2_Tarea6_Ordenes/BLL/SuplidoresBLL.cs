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
    public class SuplidoresBLL
    {
        public static Suplidores Buscar(int id)
        {
            Suplidores suplidor = new Suplidores();
            Contexto contexto = new Contexto();

            try
            {
                suplidor = contexto.Suplidores.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return suplidor;
        }

        public static List<Suplidores> GetList(Expression<Func<Suplidores,bool>> criterio)
        {
            List<Suplidores> lista = new List<Suplidores>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Suplidores.Where(criterio).ToList();
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
