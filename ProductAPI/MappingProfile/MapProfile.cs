using AutoMapper;
using ProductAPI.DTOs;
using ProductAPI.Entities;

namespace ProductAPI.MappingProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ProductGetDto>().ReverseMap();
            CreateMap<Product, ProductCreateDto>().ReverseMap();
            CreateMap<Product, ProductUpdateDto>().ReverseMap();
        }

    }
}
