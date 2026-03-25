using HerzingProjectTemplate.Models;
using HerzingProjectTemplate.Services;
using Microsoft.AspNetCore.Mvc;

namespace HerzingProjectTemplate.Controllers
{
    public class NutritionController : Controller
    {
        private readonly IHealthCalculatorService _calculator;
        private readonly IUserProfileRepository _profileRepo;

        public NutritionController(
            IHealthCalculatorService calculator,
            IUserProfileRepository profileRepo)
        {
            _calculator = calculator;
            _profileRepo = profileRepo;
        }

        public IActionResult Index()
        {
            // 1. Get the logged-in user's profile
            var profile = _profileRepo.GetProfileForUser(User.Identity!.Name);

            if (profile == null)
            {
                // Redirect user to fill out profile first
                return RedirectToAction("Create", "UserProfileInfo");
            }

            // 2. Calculate BMR
            double bmr = _calculator.CalculateBmr(
                profile.Age,
                profile.Height,
                profile.Weight,
                profile.Gender
            );

            // 3. Calculate TDEE using stored activity level
            double tdee = _calculator.CalculateTdee(
                bmr,
                profile.ActivityLevel // e.g., 1.2, 1.375, 1.55, etc.
            );

            // 4. Build the view model
            var model = new Nutrition
            {
                BMR = bmr,
                TDEE = tdee,
                Profile = profile
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult FoodEntry(Nutrition entry)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(new
            {
                Message = "Food entry received successfully",
                Data = entry
            });
        }
    }
}






































//using HerzingProjectTemplate.Models;
//using HerzingProjectTemplate.Services;
//using Microsoft.AspNetCore.Mvc;

//namespace HerzingProjectTemplate.Controllers
//{
//    public class NutritionController : Controller
//    {
//        public IActionResult Index()
//        {
//            return View();
//        }


//        [HttpPost]
//        public IActionResult FoodEntry(Nutrition entry)
//        {
//            if (!ModelState.IsValid)
//            {
//                return BadRequest(ModelState);
//            }


//            return Ok(new
//            {
//                Message = "Food entry received successfully",
//                Data = entry
//            });
//        }
//    }

//}


