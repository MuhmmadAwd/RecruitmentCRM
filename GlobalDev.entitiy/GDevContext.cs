using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalDev.Dal

{
    public class GDevContext : DbContext
    {
        public GDevContext() : base()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<GDevContext, GlobalDev.Dal.Migrations.Configuration>());
        }
        public virtual DbSet<Students> Students { get; set; }
    }
}
