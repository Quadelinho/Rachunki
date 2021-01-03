using Rachunki.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rachunki.DBContext
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Bill> Bills { get; set; }
        public DatabaseContext():base(GetConnection(), false) { }

        public static DbConnection GetConnection()
        {
            var connection = ConfigurationManager.ConnectionStrings["SQLiteConnection"];
            var factory = DbProviderFactories.GetFactory(connection.ProviderName);
            var dbCon = factory.CreateConnection();
            dbCon.ConnectionString = connection.ConnectionString;
            return dbCon;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new BillMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
