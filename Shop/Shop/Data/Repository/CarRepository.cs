using Microsoft.EntityFrameworkCore;
using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AddDbContent addDbContent;
        public CarRepository(AddDbContent addDbContent) { this.addDbContent = addDbContent; }
        public IEnumerable<Car> Cars => addDbContent.Car.Include(c=>c.Category);

        public IEnumerable<Car> getFavCars => addDbContent.Car.Where(p => p.isFavourite).Include(c => c.Category);

        public Car getObjectCar(int carId) => addDbContent.Car.FirstOrDefault(p=>p.id==carId);
    }
}
