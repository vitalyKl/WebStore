using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Data;
using WebStore.Models;
using WebStore.Services.Interfaces;

namespace WebStore.Services
{
    public class InMemoryEmployeesData: IEmployeesData
    {
       
        private int _CurrentMaxId;

        public InMemoryEmployeesData()
        {
            _CurrentMaxId = TestData.Employees.Max(i => i.Id);
        }

        public int Add(Employee employee)
        {
            if (employee is null) throw new ArgumentNullException(nameof(employee));

            if (TestData.Employees.Contains(employee)) return employee.Id;

            employee.Id = ++_CurrentMaxId;
            TestData.Employees.Add(employee);
            return employee.Id;
        }

        public bool Delete(int id)
        {
            var db_item = Get(id);
            if (db_item is null) return false;
            return TestData.Employees.Remove(db_item);
        }

        public Employee Get(int id) => TestData.Employees.SingleOrDefault(x => x.Id == id);

        public IEnumerable<Employee> GetAll() => TestData.Employees;

        public void Update(Employee employee)
        {
            if (employee is null) throw new ArgumentNullException(nameof(employee));

            if (TestData.Employees.Contains(employee)) return;

            var db_item = Get(employee.Id);
            if (db_item is null) return;

            db_item.Name = employee.Name;
            db_item.Surname = employee.Surname;
            db_item.Patronymic = employee.Patronymic;
            db_item.Age = employee.Age;
            db_item.Degree = employee.Degree;
            db_item.Department = employee.Department;
            db_item.HiringDate = employee.HiringDate;
        }
    }
}
