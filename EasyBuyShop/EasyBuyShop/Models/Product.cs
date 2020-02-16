using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyBuyShop.Models
{
    public class Product
    {
        public int id { get; set; } 
        public string url { get; set; }
        public string nameProduct { get; set; }
        public uint price { get; set; }
        public string description { get; set; }
        public string heading { get; set; }


    }
}
