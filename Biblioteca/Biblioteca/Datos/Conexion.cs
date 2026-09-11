using Microsoft.Data.SqlClient;

namespace Biblioteca.Datos
{
    public class Conexion
    {
        private string CadenaConexion =
            "Server=(localdb)\\MSSQLLocalDB;Database=Biblioteca;Integrated security=True;TrustServerCertificate=True;";
       
        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(CadenaConexion);
        }
    }
}