using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using EasyBuyShop.Interface;
using EasyBuyShop.Models;

namespace EasyBuyShop.Models
{
    public class GetDataFromDB : IProduct
    {
        private ShopDBContent _shopDBContent;
        public GetDataFromDB(ShopDBContent shopDBContent)
        {
            _shopDBContent = shopDBContent;
        }

        public IEnumerable<Product> AllProducts
        {
            get
            {
                return _shopDBContent.Products;
            }

        }
    }
}
