using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allcars;
        private readonly ICarsCategory _allcategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allcars = iAllCars;
            _allcategories = iCarsCat;
        }
        public ViewResult List()
        {
            ViewBag.Title = "Странница с автомобилями";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = _allcars.Cars;
            obj.currCategory = "Автомобили";
            return View(obj);
        }
    }
}
