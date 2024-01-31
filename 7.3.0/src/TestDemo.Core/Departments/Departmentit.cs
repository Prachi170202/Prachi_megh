using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo.Departments
{
    public class Departmentit: FullAuditedEntity
    {
        public virtual string DepartmentName { get; set; }
        public virtual string EmployeeCount { get; set; }
    }
}
