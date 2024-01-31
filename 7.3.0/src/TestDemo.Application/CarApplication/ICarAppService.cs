using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDemo.Applicationss.Dto;
using TestDemo.CarApplication.Dto;

namespace TestDemo.CarApplication
{
    public interface ICarAppService : IApplicationService
    {
        List<CarDto> GetAllCar();
        Task CreateCar(CarDto input);
        Task UpdateCar(CarDto input);
        Task DeleteCar(int id);
    }
}
