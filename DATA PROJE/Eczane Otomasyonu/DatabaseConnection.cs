using System.Data.SqlClient;

namespace Eczane_Otomasyonu.Database
{
    public static class DatabaseConnection
    {
        private static readonly string ConnectionString = "Server=DESKTOP-6J2MESC\\SQLEXPRESS;Database=Eczane Otomasyonu;Trusted_Connection=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}