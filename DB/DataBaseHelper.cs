using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace DB_Autoparts_NVA.DB
{
    public class DataBaseHelper
    {
        private static string connectionString;
        public static DbContextOptions<ApplicationContext> Option()
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            var config = builder.Build();
            connectionString = config.GetConnectionString("DefaultConnection");
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            return optionsBuilder
                    .UseSqlServer(connectionString)
                    .Options;
        }

        public static string GetConnectionString() => connectionString;
    }
}
