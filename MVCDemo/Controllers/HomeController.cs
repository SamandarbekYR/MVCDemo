using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models.Users;
using MVCDemo.Service;
using System.Diagnostics;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private UserService _userService = new();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Created(User user)
        {
            if(ModelState.IsValid)
            {
                _userService.Add(user);
            }

            return View("Index");
        }
        public IActionResult Get()
        {
            List<User> user = _userService.GetAll();
            return View(user);
        }

        public IActionResult Login()
        {
            return View();
        }
        
    }
}
