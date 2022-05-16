using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using RecruitmentCRM.Dal;
using RecruitmentCRM.Dto;



namespace RecruitmentCRM.Bal
{
    public class StudentService
    {
        private readonly RecruitmentCRMContext Context;
        public StudentService(RecruitmentCRMContext context)
        {
            Context = context;
        }
        public IEnumerable<Students> GetAll()
        {
            return Context.Set<Students>().ToList();
        }

        public void Save()
        {
            Context.SaveChanges();
        }

        public void Add(StudentDto studentDto)
        {
            studentDto.CreationDate = DateTime.Now;
            studentDto.CreatedBy = 1;

            Mappers mappers = new Mappers();
            var Student = mappers.Map<StudentDto, Students>(studentDto);

            Context.Set<Students>().Add(Student);
        }
    }
}
