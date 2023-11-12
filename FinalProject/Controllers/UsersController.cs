using FinalProject.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        public UsersController(ApplicationDbContext db) {
            _db = db;
        }
        private readonly ApplicationDbContext _db;
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult addUser([FromForm] User user) {
            _db.users.Add(user);
            _db.SaveChanges();
            return View("login");
        }
        [HttpGet]
        public IActionResult getUser([FromForm] String email, [FromForm] String password)
        {
            List<User> users = _db.users.ToList();
            var result = users.Where(n => n.userMail == email && n.userPassword == password).FirstOrDefault();
            if (result == null)
            {
                return BadRequest("The User Not Found");
            }
            else
            {
                return Ok("The User Found");
            }
        }

    }
}
