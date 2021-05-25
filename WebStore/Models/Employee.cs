using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronomyc { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        public DateTime HiringDate { get; set; }
        public string Degree { get; set; }

    }
}
