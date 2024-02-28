﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ShopTest.Entity
{
    public class MilkDep
    {
        public int Id { get; set; }
        public string? Name_Prod { get; set; }
        public int? Count { get; set; }
        public decimal? Price { get; set; }
        public int? ProductStore_Id { get; set; }
        public int? Department_Id { get; set; }
        public ProductStore? ProductStore { get; set; }
        public Department? Department { get; set; }
    }
}
