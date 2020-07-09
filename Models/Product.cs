using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace assignment.Models
{
    public class Product
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
    }
}