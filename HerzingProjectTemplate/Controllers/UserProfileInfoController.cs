using HerzingProjectTemplate.Models;
using Microsoft.AspNetCore.Mvc;

namespace HerzingProjectTemplate.Controllers
{
    public class UserProfileInfoController : Controller
    {
        [HttpGet]
        public IActionResult Input()
        {
            return View();
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

            return View("Result", model);
        }
    }
}

