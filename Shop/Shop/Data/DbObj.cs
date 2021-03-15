using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DbObj
    {
        public static void Initial(AddDbContent content)
        {

            if(!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }
            if(!content.Car.Any())
            {
                content.AddRange(
                     new Car
                     {
                         name = "Tesla One",
                         shortDesc = "Лучшее за свои деньги",
                         longDesc = "Автомобиль тесла ван ",
                         price = 25000,
                         img = "/img/tesla1.jpg",
                         isFavourite = false,
                         available = true,
                         Category = Categories["Электромобили"]
                     },
                new Car
                {
                    name = "Tesla Two",
                    shortDesc = "Топ",
                    longDesc = "Автомобиль тесла ту",
                    price = 47000,
                    img = "/img/tesla2.jpg",
                    isFavourite = true,
                    available = true,
                    Category = Categories["Электромобили"]
                },
                new Car
                {
                    name = "Bmw",
                    shortDesc = "Норм тема",
                    longDesc = "Автомобиль бмв",
                    price = 15000,
                    img = "/img/bmw.jpg",
                    isFavourite = true,
                    available = false,
                    Category = Categories["Классические автомобили"]
                },
                new Car
                {
                    name = "Lada",
                    shortDesc = "Говно",
                    longDesc = "Автомобиль говно",
                    price = 100,
                    img = "/img/lada-vesta.jpg",
                    isFavourite = false,
                    available = true,
                    Category = Categories["Классические автомобили"]
                },
                new Car
                {
                    name = "Honda",
                    shortDesc = "Ну так",
                    longDesc = "Автомобиль хонда",
                    price = 7000,
                    img = "/img/xonda.jpg",
                    isFavourite = false,
                    available = true,
                    Category = Categories["Классические автомобили"]
                }
                    );
            }
            content.SaveChanges();
        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string,Category> Categories {
            get
            {
                if (category == null)
                {
                    var list = new Category[] {
                        new Category {categoryName = "Электромобили", desc ="Современный вид транспорта"},
                        new Category {categoryName ="Классические автомобили", desc="Машины с двигателем внутреннего сгорания"}
                                              };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }
                return category;
            }
        } 
        
    }
}
