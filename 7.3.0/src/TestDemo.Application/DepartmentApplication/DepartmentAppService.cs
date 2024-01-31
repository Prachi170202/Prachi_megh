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
using TestDemo.DepartmentApplication.Dto;
using TestDemo.Departments;


namespace TestDemo.DepartmentApplication
{
    public class DepartmentAppService : TestDemoApplicationModule, IDepartmentAppService
    {
        private readonly IRepository<Departmentit> _departmentRepository;
        

        public DepartmentAppService(IRepository<Departmentit> departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public List<DepartmentDto> GetAllPeople()
        {
            var person = (from d in _departmentRepository.GetAll()
                          select new DepartmentDto
                          {
                              DepartmentName = d.DepartmentName,
                              EmployeeCount = d.EmployeeCount,
                              // Add other properties as needed
                          }).ToList();
            return person;
        }

        public async Task CreatePerson(DepartmentDto input)
        {
            var person = input.MapTo<Departmentit>();
            await _departmentRepository.InsertAsync(person);
        }

        public async Task UpdatePerson(DepartmentDto input)
        {
            var person = await _departmentRepository.GetAsync(input.Id);
            person.DepartmentName = input.DepartmentName;
            person.EmployeeCount = input.EmployeeCount;
            await _departmentRepository.UpdateAsync(person);
        }

        public async Task Delete(int id)
        {
            await _departmentRepository.DeleteAsync(id);
        }

       
    }
}
