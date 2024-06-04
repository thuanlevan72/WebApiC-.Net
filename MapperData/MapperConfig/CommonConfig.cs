using AutoMapper;
using Entity.Models;
using MapperData.DtoMapperData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperData.MapperConfig
{
    public class CommonConfig: Profile
    {
        public CommonConfig() {

            CreateMap<Acccount, AccountDto>()
              .ForMember(dest => dest.AuthorityName, opt => opt.MapFrom(src => src.Decentralization.AuthorityName));
          
        }
    }
}
