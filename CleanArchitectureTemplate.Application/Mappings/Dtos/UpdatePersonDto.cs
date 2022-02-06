using AutoMapper;
using System;

namespace CleanArchitectureTemplate.Application.Mappings.Dtos
{
    public class UpdatePersonDto : Profile
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
