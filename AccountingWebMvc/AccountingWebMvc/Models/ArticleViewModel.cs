using System;
using System.ComponentModel.DataAnnotations;

namespace AccountingWebMvc.Models
{
    public class ArticleViewModel
    {
        public Guid Id { get; set; }

        [Display(Name = "Наименование")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Тип")]
        [Required]
        public ArticleTypes Type { get; set; }
    }
}