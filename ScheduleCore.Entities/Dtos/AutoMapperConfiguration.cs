using AutoMapper;
using ScheduleCore.Entities.Models;

namespace ScheduleCore.Entities.Dtos
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Province, ProvinceDto>().ReverseMap();
        }
    }
}
