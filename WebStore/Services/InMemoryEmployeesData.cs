using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;
using WebStore.Services.Interfaces;

namespace WebStore.Services
{
    public class InMemoryEmployeesData: IEmployeesData
    {
        private static readonly List<Employee> _Employees = new()
        {
            new Employee { Id = 1, Age = 20, Name = "Александр", Patronomyc = "Сергеевич", Surname = "Пушкин", Department = "Продажи", HiringDate = new DateTime(2010, 11, 15), Degree = "Высшее" },
            new Employee { Id = 2, Age = 38, Name = "Вячеслав", Patronomyc = "Михайлович", Surname = "Губерниев", Department = "Логистика", HiringDate = new DateTime(2010, 11, 05), Degree = "Среднее" },
            new Employee { Id = 3, Age = 31, Name = "Дмитрий", Patronomyc = "Витальевич", Surname = "Соловей", Department = "Закупки", HiringDate = new DateTime(2010, 11, 01), Degree = "Высшее" }
        };
        private int _CurrentMaxId;

        public InMemoryEmployeesData()
        {
            _CurrentMaxId = _Employees.Max(i => i.Id);
        }

        public int Add(Employee employee)
        {
            if (employee is null) throw new ArgumentNullException(nameof(employee));

            if (_Employees.Contains(employee)) return employee.Id;

            employee.Id = ++_CurrentMaxId;
            _Employees.Add(employee);
            return employee.Id;
        }

        public bool Delete(int id)
        {
            var db_item = Get(id);
            if (db_item is null) return false;
            return _Employees.Remove(db_item);
        }

        public Employee Get(int id) => _Employees.SingleOrDefault(x => x.Id == id);

        public IEnumerable<Employee> GetAll() => _Employees;

        public void Update(Employee employee)
        {
            if (employee is null) throw new ArgumentNullException(nameof(employee));

            if (_Employees.Contains(employee)) return;

            var db_item = Get(employee.Id);
            if (db_item is null) return;

            db_item.Name = employee.Name;
            db_item.Surname = employee.Surname;
            db_item.Patronomyc = employee.Patronomyc;
            db_item.Age = employee.Age;
            db_item.Degree = employee.Degree;
            db_item.Department = employee.Department;
            db_item.HiringDate = employee.HiringDate;
        }
    }
}
