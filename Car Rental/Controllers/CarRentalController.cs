﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Car_Rental.Models;

namespace Car_Rental.Controllers
{
    public class CarRentalController : Controller
    {
        public ActionResult Index()
        {
            //mock
            var viewModel = new CarRentalsViewModel
            {
                CarRentals = new List<CarRentalViewModel>
                {
                    new CarRentalViewModel
                    {
                        Car = new CarViewModel
                        {
                            Brand = "Golf",
                            PricePerDay = 100,
                            EngineCapacity = 1.3,
                            Yearbook = "1993",
                            NumberOfSeats = 4,
                            Type = "sportowe",
                            Model = "Trójka",
                            Power = 80
                        }
                    }
                }
            };

            return View("Index", viewModel);
        }
    }
}