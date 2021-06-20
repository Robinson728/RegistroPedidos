using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistroPedidos.DAL;
using RegistroPedidos.Models;
using System.Linq.Expressions;

namespace RegistroPedidos.BLL
{
    public class ProductosBLL
    {
        public static Productos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Productos productos;

            try
            {
                productos = contexto.Productos.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return productos;
        }

        public static List<Productos> GetList(Expression<Func<Productos, bool>> criterio)
        {
            Contexto contexto = new Contexto();
            List<Productos> lista = new List<Productos>();

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
