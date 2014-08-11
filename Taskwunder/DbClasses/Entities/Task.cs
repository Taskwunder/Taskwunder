using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbClasses
{
    public class Task : BaseEntity
    {
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public virtual IEnumerable<Expert> Experts { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }
    }
}
