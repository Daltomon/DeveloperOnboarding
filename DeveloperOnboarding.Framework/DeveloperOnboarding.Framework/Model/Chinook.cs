using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperOnboarding.Framework.Model
{
   public class Chinook : DbContext
   {
      private static readonly Func<string, SQLiteConnection> ConnectionFactory =
         filename => new SQLiteConnection
         {
            ConnectionString = new SQLiteConnectionStringBuilder
            {
               DataSource = filename,
               ForeignKeys = true
            }.ConnectionString
         };

      public DbSet<Album> Albums { get; set; }
      public DbSet<Artist> Artists { get; set; }

      public Chinook(string filename) : base(ConnectionFactory(filename), true)
      {
         // Turn off the Migrations, (NOT a code first Db)
         Database.SetInitializer<Chinook>(null);
      }

      protected override void OnModelCreating(DbModelBuilder modelBuilder)
      {
         // Database does not pluralize table names
         modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
      }
   }
}
