using dawp_lecture_2.Data;
using dawp_lecture_2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dawp_lecture_2.Controllers
{
    public class DogsController(Lec2DBData dbContext) : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var dogs = await dbContext.Dogs.ToListAsync();
            return View(dogs);
        }
        [HttpGet]
        public IActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> create(Dog dog)
        {

            if (ModelState.IsValid)
            {
                // add dog to the database
                var result = await dbContext.Dogs.AddAsync(dog);
                await dbContext.SaveChangesAsync();
                return Redirect("/dogs/index");
            }

            return View(dog);



        }

    }
}
