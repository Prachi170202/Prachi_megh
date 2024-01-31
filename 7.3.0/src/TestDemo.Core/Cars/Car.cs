using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo.Cars
{
    public class Car : FullAuditedEntity
    {
        public virtual string CarName { get; set; }
        public virtual decimal CarPrice { get; set;}
    }
}
