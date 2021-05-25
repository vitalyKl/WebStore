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
            new Employee { Id = 1, Age = 20, Name = "Александр", Patronomyc = "Сергеевич", Surname = "Пушкин", Department = "Продажи", HiringDate = new DateTime(2010, 11, 15), Degree = "Высшее" },
            new Employee { Id = 2, Age = 38, Name = "Вячеслав", Patronomyc = "Михайлович", Surname = "Губерниев", Department = "Логистика", HiringDate = new DateTime(2010, 11, 05), Degree = "Среднее" },
            new Employee { Id = 3, Age = 31, Name = "Дмитрий", Patronomyc = "Витальевич", Surname = "Соловей", Department = "Закупки", HiringDate = new DateTime(2010, 11, 01), Degree = "Высшее" }
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

        public IActionResult Details(int Id)
        {
            return View(_Employees[Id-1]);
        }
    }
}
