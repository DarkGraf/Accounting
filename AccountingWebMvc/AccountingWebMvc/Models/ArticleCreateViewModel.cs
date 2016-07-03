using System;
using System.ComponentModel.DataAnnotations;

namespace AccountingWebMvc.Models
{
    public class ArticleCreateViewModel
    {
        [Display(Name = "Наименование")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Тип")]
        [Required]
        public ArticleTypes Type { get; set; }
    }
}