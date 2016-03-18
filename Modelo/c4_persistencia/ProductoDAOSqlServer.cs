using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.c3_dominio.contrato;
using Modelo.c3_dominio.entidad;
using System.Data.SqlClient;

namespace Modelo.c4_persistencia
{
    public class ProductoDAOSqlServer : IProductoDAO
    {
        string conexionString = "data source=yfbhz1zuj2.database.windows.net,1433;initial catalog=pruebaweb;persist security info=True;user id=administrador;password=Password*123;MultipleActiveResultSets=True;";
        SqlConnection conexionBase;
        SqlCommand comandos;
        SqlDataReader reader;
        public List<Producto> buscarProducto()
        {
            List<Producto> listaproductos = new List<Producto>();

            using (conexionBase = new SqlConnection(conexionString))
            {
                comandos = new SqlCommand("select p.codigoproducto, p.nombreproducto, p.descripcionproducto,p.detallesproducto, p.precioproducto from producto p", conexionBase);
                try
                {
                    conexionBase.Open();
                    reader = comandos.ExecuteReader();
                    while (reader.Read())
                    {
                        Producto producto = new Producto();
                        producto.codigoProducto = (int)reader[0];
                        producto.nombreProducto = (string)reader[1];
                        producto.descripcionProducto = (string)reader[2];
                        producto.detalleProducto = (string)reader[3];
                        producto.precioProducto=(decimal)reader[4];
                        listaproductos.Add(producto);
                    }
                }
                catch (SqlException e) {
                    throw;
                }

            }
            return listaproductos;
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
