using AutoMapper;
using CleanArchitectureTemplate.Domain;

namespace CleanArchitectureTemplate.Application.Mappings.Dtos
{
    public class CreatePeronDto : Profile
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

    }
}
