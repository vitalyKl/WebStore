using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;

namespace WebStore.Data
{
    public static class TestData
    {
        public static List<Employee> Employees = new()
        {
            new Employee { Id = 1, Age = 20, Name = "Александр", Patronymic = "Сергеевич", Surname = "Пушкин", Department = "Продажи", HiringDate = new DateTime(2010, 11, 15), Degree = "Высшее" },
            new Employee { Id = 2, Age = 38, Name = "Вячеслав", Patronymic = "Михайлович", Surname = "Губерниев", Department = "Логистика", HiringDate = new DateTime(2010, 11, 05), Degree = "Среднее" },
            new Employee { Id = 3, Age = 31, Name = "Дмитрий", Patronymic = "Витальевич", Surname = "Соловей", Department = "Закупки", HiringDate = new DateTime(2010, 11, 01), Degree = "Высшее" }
        };
    }
}
