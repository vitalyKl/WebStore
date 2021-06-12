using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.ViewModels
{
    public class EmployeeViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [Display(Name="Имя")]
        [Required(ErrorMessage = "Не указано имя")]
        [StringLength(200, MinimumLength = 2, ErrorMessage ="Длина имени должна быть от 2 до 200 символов!")]
        [RegularExpression(@"([А-ЯЁ][а-яё]+)|([A-Z][a-z]+)", ErrorMessage ="Использоваться могут только кириллица или латиница!")]
        public string Name { get; set; }
        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Не указано имя")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Длина фамилии должна быть от 2 до 200 символов!")]
        [RegularExpression(@"([А-ЯЁ][а-яё]+)|([A-Z][a-z]+)", ErrorMessage = "Использоваться могут только кириллица или латиница!")]
        public string Surname { get; set; }
        [Display(Name = "Отчество")]
        [Required(ErrorMessage = "Не указано имя")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Длина отчества должна быть от 2 до 200 символов!")]
        [RegularExpression(@"([А-ЯЁ][а-яё]+)|([A-Z][a-z]+)", ErrorMessage = "Использоваться могут только кириллица или латиница!")]
        public string Patronymic { get; set; }
        [Display(Name = "Возраст")]
        [Range(18,80, ErrorMessage ="Возраст должен быть от 18 до 80 лет!")]
        public int Age { get; set; }
        [Display(Name = "Дата найма")]
        public DateTime HiringDate { get; set;}
        [Display(Name = "Отдел")]
        public string Department { get; set; }
        [Display(Name = "Образование")]
        public string Degree { get; set; }

    }
}
