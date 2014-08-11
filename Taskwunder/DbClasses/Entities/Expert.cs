using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbClasses
{
    public class Expert : BaseEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Skills { get; set; }
        public int Rating { get; set; }
        public virtual IEnumerable<Task> Tasks { get; set; }
    }
}
