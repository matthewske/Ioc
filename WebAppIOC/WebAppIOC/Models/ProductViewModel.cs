﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppIOC.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; internal set; }
    }
}
