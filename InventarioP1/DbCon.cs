using System;
using System.Data.SqlClient;

namespace InventarioP1
{
    class DbCon
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection Conexion = new SqlConnection(@"Data Source=192.168.101.100; Initial Catalog=INVENTARIO; MultipleActiveResultSets = true;User ID=sa; Password=Admin_sqlABG");
            return Conexion;
        }
    }
}
