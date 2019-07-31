using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPExample.Models;

namespace ASPExample.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ToCreateCar()
        {
            return View();
        }

        public IActionResult CreateCar(Car CreatedCar)
        {
            CarViewModel.Cars.Add(CreatedCar);
            return RedirectToAction("Index");
        }
    }
}