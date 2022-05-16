using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace RecruitmentCRM.Dal
{
    public class RecruitmentCRMContext : DbContext
    {
        public RecruitmentCRMContext() : base()
        {
        }
        public virtual DbSet<Students> Students { get; set; }

    }
}
