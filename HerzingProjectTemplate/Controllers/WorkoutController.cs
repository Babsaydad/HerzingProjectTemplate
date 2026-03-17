using HerzingProjectTemplate.Models;
using Microsoft.AspNetCore.Mvc;

namespace HerzingProjectTemplate.Controllers
{
    public class WorkoutController : Controller
    {
        //[HttpGet]
        //public IActionResult Index()
        //{
        //    // Initializing with an empty list avoids null reference 
        //    // errors in some view configurations
        //    var model = new Workout { SelectedExercises = new List<string>() };
        //    return View(model);
        //}

        [HttpGet]
        public IActionResult Index()
        {
            // You "set it in the object initializer" here
            var model = new Workout
            {
                SelectedWorkoutType = "", // Satisfies the compiler
                SelectedExercises = new List<string>()
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // Error Fix #3: Security
        public IActionResult Index(Workout model)
        {
            if (!ModelState.IsValid)
            {
                // Error Fix #2: Logic
                // When returning the view, the JS in your .cshtml 
                // needs to know which workout type was selected 
                // so it can re-inject the correct cards.
                return View(model);
            }

            // Process form (save to DB, etc.)
            // _context.Workouts.Add(model);
            // _context.SaveChanges();

            return RedirectToAction("Success");
        }

        // Error Fix #1: Missing Action
        [HttpGet]
        public IActionResult Success()
        {
            return View();
        }
    }
}







    //public class WorkoutController : Controller
    //{
    //    [HttpGet]
    //    public IActionResult Index()
    //    {
    //        return View(new Workout());
    //    }

    //    [HttpPost]
    //    public IActionResult Index(Workout model)
    //    {
    //        if (!ModelState.IsValid)
    //            return View(model);

    //        // Process form (save, send email, etc.)
    //        return RedirectToAction("Success");
    //    }
    //}





