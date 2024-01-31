using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDemo.Applicationss.Dto;

namespace TestDemo.Applicationss
{
    public interface IPersonAppService: IApplicationService
    {
        List<PersonDto> GetAllPeople();
        Task CreatePerson(PersonDto input);
        Task UpdatePerson(PersonDto input);
        Task DeletePerson(int id);

    }
}
