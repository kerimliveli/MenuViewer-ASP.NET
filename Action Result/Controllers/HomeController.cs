using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Action_Result.Entities;
using Action_Result.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Action_Result.Controllers
{
    public class HomeController : Controller
    {

        public string Index()
        {
            return "Home";
        }

        public ViewResult Drinks1()
        {
            List<Drinks> drinks = new List<Drinks>()
            {
                new Drinks()
                {
                    Id = 1,
                    Name = "Cola",
                },


                new Drinks()
                {
                    Id = 2,
                    Name = "Fanta",
                },


                new Drinks()
                {
                    Id = 3,
                    Name = "Sprite",
                },
            };


            return View(drinks);


        }


        public ViewResult Hotmeals1()
        {
            List<Hotmeals> hotmeals = new List<Hotmeals>()
            {
                new Hotmeals()
                {
                    Id = 1,
                    Name = "Roast Beef with Mashed Potatoes"
                },


                new Hotmeals()
                {
                    Id = 2,
                    Name = "Spaghetti Bolognese",
                },


                new Hotmeals()
                {
                    Id = 3,
                    Name = "Chicken Curry with Rice",
                },
            };


            return View(hotmeals);


        }


        public ViewResult Fastfood1()
        {
            List<Fastfoods> fastfoods = new List<Fastfoods>()
            {
                new Fastfoods()
                {
                    Id = 1,
                    Name = "Cheeseburger",
                },


                new Fastfoods()
                {
                    Id = 2,
                    Name = "Pepperoni Pizza",
                },


                new Fastfoods()
                {
                    Id = 3,
                    Name = "Fried Chicken",
                },
            };


           


            return View(fastfoods);


        }



    }
}
