using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using RecruitmentCRM.Dal;

namespace RecruitmentCRM.Dto
{
    public class Mappers
    {
        public T2 Map<T1, T2>(T1 t1)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<T1, T2>());

            var mapper = config.CreateMapper();

            var Tentity = mapper.Map<T1, T2>(t1);
            return Tentity;
        }

    }

}
