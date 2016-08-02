using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;
using System.Data.SQLite;
using System.Data.SQLite.EF6;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperOnboarding.Framework.Config
{
   /// <summary>
   /// This class is reflectively accessed by entity framework to set up connection info for the ChinookContext
   /// </summary>
   internal class ChinookDbConfiguration : DbConfiguration
   {
      public ChinookDbConfiguration()
      {
         SetExecutionStrategy("System.Data.SQLite.EF6", () => new DefaultExecutionStrategy());
         SetDefaultConnectionFactory(new LocalDbConnectionFactory("v13.0"));
         SetProviderFactory("System.Data.SQLite.EF6", new SQLiteProviderFactory());
         SetProviderFactory("System.Data.SQLite", new SQLiteFactory());
         SetProviderServices("System.Data.SQLite", (DbProviderServices)SQLiteProviderFactory.Instance.GetService(typeof(DbProviderServices)));
      }
   }
}
