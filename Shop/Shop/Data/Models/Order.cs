using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name="Введите имя")]
        [MaxLength(20)]
        [Required(ErrorMessage ="Длина имени не менее 5 и не больше 20")]
        public string name { get; set; }
        [Display(Name = "Фамилия")]
        [MaxLength(20)]
        [Required(ErrorMessage = "Длина фамилии не больше 20")]
        public string surname { get; set; }
        [Display(Name = "Адресс")]
        [MaxLength(150)]
        [Required(ErrorMessage = "Длина адресса не менее 5 и не больше 50")]
        public string adress { get; set; }
        [Display(Name = "Телефон")]
        [MaxLength(12)] 
        [Required(ErrorMessage = "Неверный номер")]
        public string phone { get; set; }
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime ordertime { get; set; }
        public List<OrderDetail> orderdetails{ get; set; }


    }
}
