using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;
using WebStore.Services.Interfaces;
using WebStore.ViewModels;

namespace WebStore.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeesData _EmployeesData;

        public EmployeesController(IEmployeesData EmployeesData)
        {
            _EmployeesData = EmployeesData;
        }
        

        public IActionResult Index()
        {
            return View(_EmployeesData.GetAll());
        }

        public IActionResult Details(int id)
        {
            var employee = _EmployeesData.Get(id);

            if (employee == null)
                return NotFound();

            return View(employee);
        }

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Edit(EmployeeViewModel model)
        {
            var employee = new Employee
            {
                Id = model.Id,
                Name = model.Name,
                Surname = model.Surname,
                Patronymic = model.Patronymic,
                Age = model.Age,
                HiringDate = model.HiringDate,
                Degree = model.Degree,
                Department = model.Department,
            };

            _EmployeesData.Update(employee);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var employee = _EmployeesData.Get(id);
            if (employee is null) return NotFound();

            var viewModel = new EmployeeViewModel
            {
                Id = employee.Id,
                Name = employee.Name,
                Surname = employee.Surname,
                Patronymic = employee.Patronymic,
                Age = employee.Age,
                HiringDate = employee.HiringDate,
                Degree = employee.Degree,
                Department = employee.Department,
            };
            return View(viewModel);
        }

        public IActionResult Delete(int id) => View();
    }
}
