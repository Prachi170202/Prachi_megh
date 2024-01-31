using Abp.Application.Services;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDemo.Applicationss;
using TestDemo.Applicationss.Dto;
using TestDemo.CarApplication.Dto;
using TestDemo.Cars;

namespace TestDemo.CarApplication 
{
    public class CarAppService : TestDemoApplicationModule, ICarAppService
    {
        private readonly IRepository<Car> _carRepository;

        public CarAppService(IRepository<Car> carRepository)
        {
            _carRepository = carRepository;
        }

        public List<CarDto> GetAllCar()
        {
            var mycar = (from r in _carRepository.GetAll()
                          select new CarDto
                          {
                              CarName = r.CarName,
                              CarPrice = r.CarPrice,
                              // Add other properties as needed
                          }).ToList();
            return mycar;
        }

        public async Task CreateCar(CarDto input)
        {
            var mycar = input.MapTo<Car>();
            await _carRepository.InsertAsync(mycar);
        }

        public async Task UpdateCar(CarDto input)
        {
            var mycar = await _carRepository.GetAsync(input.Id);
            mycar.CarName = input.CarName;
            mycar.CarPrice = input.CarPrice;
            await _carRepository.UpdateAsync(mycar);
        }

        public Task DeleteCar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
