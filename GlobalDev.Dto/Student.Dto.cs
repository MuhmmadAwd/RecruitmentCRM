using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using AutoMapper;

namespace GlobalDev.Dto
{

    public class StudentDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string LinkedinAccount { get; set; }
        public string Experience { get; set; }
        public string SeniorityLevel { get; set; }
        public string StudySubject { get; set; }
        [Column(TypeName = "date")]
        public DateTime GraduatDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime ApplyDate { get; set; }
        public string Country { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }

    }

}
