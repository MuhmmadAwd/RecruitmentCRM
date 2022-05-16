using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentCRM.Dal
{
    public class Domain
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public long CreatedBy { get; set; }
        [Column(TypeName = "date")]
        public DateTime UpdateDate { get; set; }
        public long UpdatedBy { get; set; }
        public int StudentId { get; set; }
        public Students Students { get; set; }
    }
}
