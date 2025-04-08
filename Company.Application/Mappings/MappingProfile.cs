using AutoMapper;
using Company.Application.DTOs;
using Company.Domain.Entity;

namespace Company.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Villa, VillaDto>().ReverseMap();
            CreateMap<Villa, CreateUpdateVillaDto>().ReverseMap();
        }

    }
}
