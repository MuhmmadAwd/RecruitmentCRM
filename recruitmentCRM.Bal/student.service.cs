using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using recruitmentCRM.Dal;
using recruitmentCRM.Dto;



namespace recruitmentCRM.Bal
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
            Mappers mappers = new Mappers();
            var Student = mappers.Map<StudentDto, Students>(studentDto);

            Context.Set<Students>().Add(Student);
        }
    }
}
