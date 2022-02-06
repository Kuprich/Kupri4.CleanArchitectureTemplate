using AutoMapper;
using CleanArchitectureTemplate.Application.Mappings.Dtos;
using CleanArchitectureTemplate.Domain;
using CleanArchitectureTemplate.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace CleanArchitectureTemplate.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly PersonDbcontext _dbContext;
        private readonly IMapper _mapper;

        public PersonController(PersonDbcontext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _dbContext.Persons.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            Person person = await _dbContext.Persons.FindAsync(id);

            if (person == null)
            {
                return NotFound();
            }

            return Ok(person);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreatePeronDto dto)
        {
            Person person = _mapper.Map<Person>(dto);
            person.Id = Guid.NewGuid();

            _dbContext.Persons.Add(person);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }


        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdatePersonDto dto)
        {
            Person person = await _dbContext.Persons.FindAsync(dto.Id);

            if (person == null)
            {
                return NotFound();
            }

            _dbContext.Entry(person).CurrentValues.SetValues(_mapper.Map<Person>(dto));

            await _dbContext.SaveChangesAsync();

            return Ok();
        }
    }
}
