using Abp.Application.Services;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDemo.Applicationss.Dto;
using TestDemo.Persons;

namespace TestDemo.Applicationss
{
    public class PersonAppService:TestDemoApplicationModule,IPersonAppService
    {
        private readonly IRepository<Person> _personRepository;

        public PersonAppService(IRepository<Person> personRepository)
        {
            _personRepository = personRepository;
        }

        public List<PersonDto> GetAllPeople()
        {
            var person = (from p in _personRepository.GetAll()
                              select new PersonDto
                              {
                                  FirstName = p.FirstName,
                                  LastName = p.LastName,
                                  // Add other properties as needed
                              }).ToList();
            return person;
        }

        public async Task CreatePerson(PersonDto input)
        {
            var person = input.MapTo<Person>();
            await _personRepository.InsertAsync(person);
        }

        public async Task UpdatePerson(PersonDto input)
        {
            var person = await _personRepository.GetAsync(input.Id);
            person.FirstName = input.FirstName;
            person.LastName = input.LastName;
            await _personRepository.UpdateAsync(person);
        }

        public async Task DeletePerson(int id)
        {
            await _personRepository.DeleteAsync(id);
        }
    }
}

