using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDemo.Applicationss.Dto;
using TestDemo.DepartmentApplication.Dto;

namespace TestDemo.DepartmentApplication
{
    public interface IDepartmentAppService : IApplicationService
    {
        List<DepartmentDto> GetAllPeople();
        Task CreatePerson(DepartmentDto input);
        Task UpdatePerson(DepartmentDto input);
        Task Delete(int id);

    }
}
