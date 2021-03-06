﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbClasses
{
    public class Product : BaseEntity
    {
        public string Description { get; set; }
        public double Price { get; set; }
        public virtual IEnumerable<Task> Tasks { get; set; }
    }
}
