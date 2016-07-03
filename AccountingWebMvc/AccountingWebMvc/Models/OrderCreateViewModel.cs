using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AccountingWebMvc.Models
{
    public class OrderCreateViewModel
    {
        [Display(Name = "Статья")]
        [Required]
        public Guid ArticleId { get; set; }
        public Dictionary<Guid, string> Articles { get; set; }
        [Display(Name = "Сумма")]
        [Required]
        [Range(0.01, 1000000)]
        public decimal Amount { get; set; }
    }
}