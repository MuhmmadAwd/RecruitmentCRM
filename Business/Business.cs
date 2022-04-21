using AutoMapper;
using GlobalDev.Dal;
using GlobalDev.Dto;


namespace GlobalDev.Bal
{
    public class Business
    {
        private readonly GDevContext Context;
        public Business(GDevContext context)
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
          var Student =  mappers.Map<StudentDto,Students>(studentDto);

            Context.Set<Students>().Add(Student);
        }
    }
}
