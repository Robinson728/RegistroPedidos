using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;
using RegistroPedidos.DAL;
using RegistroPedidos.Models;

namespace RegistroPedidos.BLL
{
    public class SuplidoresBLL
    {
        public static Suplidores Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Suplidores suplidores;

            try
            {
                suplidores = contexto.Suplidores.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return suplidores;
        }

        public static List<Suplidores> GetList(Expression<Func<Suplidores, bool>> criterio)
        {
            Contexto contexto = new Contexto();
            List<Suplidores> lista = new List<Suplidores>();

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
