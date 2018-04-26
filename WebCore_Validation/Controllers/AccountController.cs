using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebCore_Validation.Models;

namespace WebCore_Validation.Controllers
{
    public class AccountController : Controller
    {
        public List<City> cities = new List<City>()
        {
            new City(){CityId=1,CountryId=1,CityName="Chennai"},
            new City(){CityId=2,CountryId=1,CityName="Mumbai"},
            new City(){CityId=3,CountryId=1,CityName="Banglore"},
            new City(){CityId=4,CountryId=1,CityName="Delhi"},
            new City(){CityId=5,CountryId=2,CityName="Calgary"},
            new City(){CityId=6,CountryId=2,CityName="Toronto"},
            new City(){CityId=7,CountryId=2,CityName="Vancouver"},
            new City(){CityId=8,CountryId=3,CityName="Washington"},
            new City(){CityId=9,CountryId=3,CityName="Houston"}          
        };
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            ViewBag.Countries= new List<Country>()
        {
            new Country(){CountryId=1,CountryName="India"} ,
            new Country(){CountryId=2,CountryName="Canada"} ,
            new Country(){CountryId=3,CountryName="USA"}
        };
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(SignUpModel signUpModel)
        {
            if(ModelState.IsValid)
            {
                TempData["Name"] = signUpModel.FirstName;
                return RedirectToAction("Login");
            }
            return View();
        }

        public IActionResult Terms()
        {
            return View();
        }

        public IActionResult Login()
        {
            
            return View();
        }
        public JsonResult GetCities(int CountryId)
        {
            var city = cities.Where(s => s.CountryId ==CountryId).ToList();
            return Json(city);
        }
    }
}