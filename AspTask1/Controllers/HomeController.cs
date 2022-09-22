using AspTask1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AspTask1.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Drinks()
        {
            List<Drink> drinks = new List<Drink>()
            {
                new Drink{ Name="Cappy", Price=1.20, Volume="0.5L"},
                new Drink{Name="Coca-Cola",Price=1.60,Volume="1.5L"}
            };

            return View(drinks);
        }

        public IActionResult FastFoods()
        {
            List<Fastfood> fastfoods = new List<Fastfood>()
            {
                new Fastfood{ Name="Shefburger", Price=3.40, Beef=false, Chicken=true, Size="small"},
                new Fastfood{ Name="Cheeseburger", Price=4.10, Beef=true, Chicken=false, Size="small"},
                new Fastfood{ Name="Big Sandersburger", Price=8.40, Beef=false, Chicken=true, Size="big"},
            };

            return View(fastfoods);
        }

        public IActionResult HotMeals()
        {
            List<Hotmeal> hotmeals = new List<Hotmeal>()
            {
                new Hotmeal{ Name="Dovgha", Price=2.00},
                new Hotmeal{ Name="Merci", Price=3.00},
            };

            return View(hotmeals);
        }

    }
}
