using HerzingProjectTemplate.Models;
using HerzingProjectTemplate.Services;
using Microsoft.AspNetCore.Mvc;

namespace HerzingProjectTemplate.Controllers
{
    public class UserProfileInfoController : Controller
    {
        [HttpGet]
        public IActionResult Input()
        {
            return View(new UserProfileInfo());
        }

        [HttpPost]
        public IActionResult Input(UserProfileInfo model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            double heightMeters = model.Height / 100;
            double bmi = model.Weight / (heightMeters * heightMeters);

            ViewBag.BMI = bmi;

            return View("Nutrition", model);
        }
    }
}


