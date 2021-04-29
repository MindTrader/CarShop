using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }
        [Display(Name = "Имя")]
        [StringLength(20, ErrorMessage = "Ожидается строка от 2 до 20 символов", MinimumLength = 2)]
        [Required(ErrorMessage = "Введите имя")]
        public string Name { get; set; }
        [Display(Name = "Фамилия")]
        [StringLength(20, ErrorMessage = "Ожидается строка от 2 до 20 символов", MinimumLength = 2)]
        [Required(ErrorMessage = "Введите фамилию")]
        public string Surname { get; set; }
        [Display(Name = "Адрес")]
        [StringLength(50, ErrorMessage = "Ожидается строка от 5 до 50 символов", MinimumLength = 5)]
        [Required(ErrorMessage = "Укажите адрес")]
        public string Address { get; set; }
        [Display(Name = "Номер телефона")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(12, ErrorMessage = "Ожидается строка от 10 до 12 символов", MinimumLength = 10)]
        [Required(ErrorMessage = "Укажите телефон")]
        public string Phone { get; set; }
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(30, ErrorMessage = "Ожидается строка от 2 до 30 символов", MinimumLength = 2)]
        [Required(ErrorMessage = "Укажите Email")]
        public string Email { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
