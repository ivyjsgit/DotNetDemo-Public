using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DotNetDemo.Models;
using DotNetDemo.Services;

namespace DotNetDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public  readonly IUserRepository _userRepository;

        public HomeController(ILogger<HomeController> logger, IUserRepository userRepository)
        {
            _logger = logger;
            _userRepository = userRepository;
        }
        [HttpGet()]
        public IActionResult Index()
        {
            UserViewModelToReturn model = new UserViewModelToReturn();
            IEnumerable<UserDto> allUsers = _userRepository.allUsers();
            model.allUsers = allUsers;
            return View(model);
        }

        [HttpPost()]
        public IActionResult Index([FromForm] UserViewModelToReturn model)
        {
            if (ModelState.IsValid)
            {
                var user = new UserDto();
                if (user != null)
                {
                    user.id = new Guid();
                    user.firstName = model.newUser.firstName;
                    user.lastName = model.newUser.lastName;
                    user.age = model.newUser.age;
                    _userRepository.addUser(model.newUser);
                }
                return RedirectToAction("index", "home");
            }
            else
            {
                return View(model);
            }
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
