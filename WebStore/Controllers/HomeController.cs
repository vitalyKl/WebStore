using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private static readonly List<Employee> _Employees = new()
        {
            new Employee { Id = 1, Age = 20, Name = "Александр", Patronomyc = "Сергеевич", Surname = "Пушкин" },
            new Employee { Id = 2, Age = 38, Name = "Вячеслав", Patronomyc = "Михайлович", Surname = "Губерниев" },
            new Employee { Id = 3, Age = 31, Name = "Дмитрий", Patronomyc = "Витальевич", Surname = "Соловей" }
        };

        private  readonly IConfiguration _Configuration;

        public HomeController(IConfiguration Configuration)
        {
            _Configuration = Configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SecondAction()
        {
            return Content(_Configuration["Greetings"]);
        }

        public IActionResult Employees()
        {
            return View(_Employees);
        }
    }
}
