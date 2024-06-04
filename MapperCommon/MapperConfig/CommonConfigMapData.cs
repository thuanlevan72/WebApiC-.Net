using AutoMapper;
using MapperCommon.ViewModelMapper;

namespace MapperCommon.MapperConfig
{
    internal class CommonConfigMapData: Profile
    {
        public AutoMapping()
        {
            CreateMap<MapperAutoDto, MapperAutoModel>().ForMember(dest => dest.Address2, opt => opt.MapFrom(src => src.Address));
            // Nếu bạn muốn dùng automapper từ model sang dto thì dùng dòng dưới
            //CreateMap<MapperAutoModel, MapperAutoDto>(); 
        }
    }
}
