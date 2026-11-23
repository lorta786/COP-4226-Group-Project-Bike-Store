using Microsoft.Data.SqlClient;

namespace BikeStore
{
    // Parent class for every data access class (UserDA, CustomerDA, ProductDA, ...)
    public abstract class BaseDA
    {
        // Points to the BikeStore.mdf copied next to the .exe on every build
        private static readonly string connectionString = new SqlConnectionStringBuilder
        {
            DataSource = @"(LocalDB)\MSSQLLocalDB",
            AttachDBFilename = Path.Combine(AppContext.BaseDirectory, "BikeStore.mdf"),
            IntegratedSecurity = true,
            TrustServerCertificate = true,   // local dev database, no certificate
            ConnectTimeout = 30
        }.ConnectionString;

        public static SqlConnection GetConnection() => new(connectionString);
    }
}