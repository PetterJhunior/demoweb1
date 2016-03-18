using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.c4_persistencia
{
    public class ConexionSqlServer
    {
        public string abrirConexion()
        {
            try
            {
                string conexionString = "data source=yfbhz1zuj2.database.windows.net,1433;initial catalog=pruebaweb;persist security info=True;user id=administrador;password=Password*123;MultipleActiveResultSets=True;";
                return conexionString;
            }
            catch (Exception)
            {

                throw;
            }            
        }
    }
}
