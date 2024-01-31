using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo.CarApplication.Dto
{
    public class CarDto : EntityDto
    {
        public string CarName { get; set; }
        public decimal CarPrice { get; set; }
    }
}
