using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyBuyShop.Models;

namespace EasyBuyShop.Interface
{
    public interface IProduct
    {
        IEnumerable<Product> AllProducts { get; }
    }
}
