using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AutoPartsStore {

    public class AutoStoryPartsDBContext : DbContext {
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder) {
            // IConfigurationRoot configuration = new ConfigurationBuilder()
            //     .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            //     .AddJsonFile("appsettings.json")
            //     .Build();
            // optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-IAMIJFQ\MSSQL2017;Database=AutoStore;Trusted_Connection=True;");
        }
    }
}