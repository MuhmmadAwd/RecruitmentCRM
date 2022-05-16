using RecruitmentCRM.Dal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RecruitmentCRM.Dto
{ 
    public class StudentDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string LinkedinAccountUrl { get; set; }
        public string FacebookAccountUrl { get; set; }
        public string OtherSites { get; set; }
        public int PhoneNumber { get; set; }
        public string universityMajor { get; set; }
        [Column(TypeName = "date")]
        public DateTime ExperienceYears { get; set; }
        [Column(TypeName = "date")]
        public DateTime GraduatDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime ApplyDate { get; set; }
        public string Country { get; set; }
        public string Document { get; set; }

        [NotMapped]
        public IEnumerable<HttpPostedFileBase> DocumentFile { get; set; }
        [Column(TypeName = "date")]
        public DateTime CreationDate { get; set; }
        public long CreatedBy { get; set; }
        [Column(TypeName = "date")]
        public DateTime UpdateDate { get; set; }
        public long UpdatedBy { get; set; }
        public ICollection<Note> Notes { get; set; }
        public ICollection<Domain> Domains { get; set; }

    }

}
