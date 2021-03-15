using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {

        private readonly ICarsCategory _carsCategory = new MockCategory();
        public IEnumerable<Car> Cars {
            get {
                return new List<Car>
            {
                new Car {
                    name="Tesla One", 
                    shortDesc="Лучшее за свои деньги", 
                    longDesc="Автомобиль тесла ван ", 
                    price = 25000, 
                    img = "/img/tesla1.jpg" , 
                    isFavourite=false, 
                    available=true, 
                    Category = _carsCategory.AllCategories.First()
                },
                new Car {
                    name="Tesla Two",
                    shortDesc="Топ",
                    longDesc="Автомобиль тесла ту",
                    price = 47000,
                    img = "/img/tesla2.jpg",
                    isFavourite=true,
                    available=true,
                    Category = _carsCategory.AllCategories.First()
                },
                new Car {
                    name="Bmw",
                    shortDesc="Норм тема",
                    longDesc="Автомобиль бмв",
                    price = 15000,
                    img = "/img/bmw.jpg",
                    isFavourite=true,
                    available=false,
                    Category = _carsCategory.AllCategories.Last()
                },
                new Car {
                    name="Lada",
                    shortDesc="Говно",
                    longDesc="Автомобиль говно",
                    price = 100,
                    img = "/img/lada-vesta.jpg",
                    isFavourite=false,
                    available=true,
                    Category = _carsCategory.AllCategories.Last()
                },
                new Car {
                    name="Honda",
                    shortDesc="Ну так",
                    longDesc="Автомобиль хонда",
                    price = 7000,
                    img = "/img/xonda.jpg",
                    isFavourite=false,
                    available=true,
                    Category = _carsCategory.AllCategories.Last()
                }
            };
            }

        }
        public IEnumerable<Car> getFavCars { get; set ; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
