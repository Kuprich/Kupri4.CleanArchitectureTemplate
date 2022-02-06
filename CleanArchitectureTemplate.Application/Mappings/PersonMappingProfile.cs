using AutoMapper;
using CleanArchitectureTemplate.Application.Mappings.Dtos;
using CleanArchitectureTemplate.Domain;

namespace CleanArchitectureTemplate.Application.Mappings
{
    public class PersonMappingProfile : Profile
    {
        public PersonMappingProfile()
        {
            CreateMap<UpdatePersonDto, Person>();
            CreateMap<CreatePeronDto, Person>();
        }
    }
}
