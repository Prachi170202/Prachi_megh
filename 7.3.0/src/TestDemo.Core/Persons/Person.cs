using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo.Persons
{
    public class Person: FullAuditedEntity
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
    }

}
