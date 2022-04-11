using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalDev.entitiy
{
    public class GDevContext : DbContext
    {
        public GDevContext() : base()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<GDevContext, GlobalDev.entitiy.Migrations.Configuration>());
        }
        public virtual DbSet<Students> Students { get; set; }
    }
}
