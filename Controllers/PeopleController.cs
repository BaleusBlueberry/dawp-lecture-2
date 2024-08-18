using dawp_lecture_2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dawp_lecture_2.Controllers
{
    public class PeopleController(Lec2DBData lec2Db) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var people = await lec2Db.people.ToListAsync();
            return View(people);
        }

        public async Task<IActionResult> Details(int id)
        {
            var person = await lec2Db.people.FirstOrDefaultAsync(p => p.Id == id);
            return View(person);
        }
    }
}
