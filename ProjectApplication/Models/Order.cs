using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApplication.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Введите Имя")]
        [StringLength(30)]
        [Required(ErrorMessage ="Длина имени на менее 2 символов")]
        public string name { get; set; }

        [Display(Name = "Введите Фамилию")]
        [StringLength(40)]
        [Required(ErrorMessage = "Длина фамилии на менее 5 символов")]
        public string surname { get; set; }

        [Display(Name = "Введите Адрес")]
        [StringLength(40)]
        [Required(ErrorMessage = "Длина адреса на менее 10 символов")]
        public string adress { get; set; }

        [Display(Name = "Введите номер телефона")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(12)]
        [Required(ErrorMessage = "Длина номера на менее 10 знаков")]
        public string phone { get; set; }

        [Display(Name = "Введите Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина email на менее 10 символов")]
        public string email { get; set; }
        
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime oredertime { get; set; }


        public List<OrderDetail> orderDetails { get; set; }

    }
}
