using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AccountingWebMvc.Models
{
    public class OrderIndexViewModel
    {
        public Guid Id { get; set; }
        [Display(Name = "Дата")]
        [Required]
        public DateTime CreationDate { get; set; }
        [Display(Name = "Статья")]
        [Required]
        public string ArticleName { get; set; }
        [Display(Name = "Тип")]
        [Required]
        public ArticleTypes ArticleType { get; set; }
        [Display(Name = "Сумма")]
        [Required]
        public decimal Amount { get; set; }
    }
}