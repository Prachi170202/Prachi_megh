using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo.DepartmentApplication.Dto
{
    public class DepartmentDto:EntityDto
    {
        public virtual string DepartmentName { get; set; }
        public virtual string EmployeeCount { get; set; }
    }
}
