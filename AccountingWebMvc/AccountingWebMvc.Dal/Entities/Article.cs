using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccountingWebMvc.Dal.Entities
{
    public class Article
    {
        public Article()
        {
            Orders = new List<Order>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [StringLength(25)]
        public string Name { get; set; }
        public short Sign { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}