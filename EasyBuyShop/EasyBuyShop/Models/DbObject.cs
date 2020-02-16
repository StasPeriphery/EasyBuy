using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyBuyShop.Models
{
    public class DbObject
    {
        public static void InitiallDb(ShopDBContent shopDBContent)
        {
            if (!shopDBContent.Products.Any())
            {
                shopDBContent.AddRange(
                 new Product()
                 {
                     url = "/img/moto_1.jpg",
                     nameProduct = "Suzuki Intruder",
                     price = 150000,
                     description = "Конь Агонь",
                     heading = "от бога для бога"
                 },
                 new Product()
                 {
                     url = "/img/instrument.jpg",
                     nameProduct = "Some GTR",
                     price = 10000,
                     description = "Бабалайка",
                     heading = "Мальмстин начало"
                 },
                new Product()
                {
                    url = "/img/moto_1.jpg",
                    nameProduct = "Suzuki Intruder",
                    price = 150000,
                    description = "Конь Агонь",
                    heading = "от бога для бога"
                },
                new Product()
                {
                    url = "/img/instrument.jpg",
                    nameProduct = "Some GTR",
                    price = 10000,
                    description = "Бабалайка",
                    heading = "Мальмстин начало"
                },
                new Product()
                {
                    url = "/img/moto_1.jpg",
                    nameProduct = "Suzuki Intruder",
                    price = 150000,
                    description = "Конь Агонь",
                    heading = "от бога для бога"
                },
                new Product()
                {
                    url = "/img/instrument.jpg",
                    nameProduct = "Some GTR",
                    price = 10000,
                    description = "Бабалайка",
                    heading = "Мальмстин начало"
                },
                new Product()
                {
                    url = "/img/house.jpg",
                    nameProduct = "Luxuriiiii Infiniti Gold house",
                    price = 10000000,
                    description = "Нужно много халопов для обслуги бояра",
                    heading = "Хата для бояр"
                });
                shopDBContent.SaveChanges();
            }
        }
    }
}
