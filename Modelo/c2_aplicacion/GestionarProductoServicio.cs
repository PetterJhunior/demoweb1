using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.c4_persistencia;
using Modelo.c3_dominio.contrato;
using Modelo.c3_dominio.entidad;

namespace Modelo.c2_aplicacion
{
    public class GestionarProductoServicio 
    {
        IProductoDAO productoDAO;
        public GestionarProductoServicio()
        {
            productoDAO = new ProductoDAOSqlServer();
        }
        public List<Producto> buscarProducto()
        {
            List<Producto> listaProductos = new List<Producto>();
            try
            {
                listaProductos = productoDAO.buscarProducto();                
            }
            catch (Exception)
            {
                throw;
            }
            return listaProductos;
        }

        public Producto buscarProducto(int codigoProducto)
        {
            throw new NotImplementedException();
        }

        public void crearProducto(Producto producto)
        {
            throw new NotImplementedException();
        }

        public void eliminarProducto(Producto producto)
        {
            throw new NotImplementedException();
        }

        public void modificarProducto(Producto producto)
        {
            throw new NotImplementedException();
        }
    }
}
