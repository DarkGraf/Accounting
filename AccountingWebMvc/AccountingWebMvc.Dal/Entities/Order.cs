using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccountingWebMvc.Dal.Entities
{
    public class Order
    {
        public Order()
        {
            CreationDate = DateTime.Now;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public Guid ArticleId { get; set; }
        [ForeignKey("ArticleId")]
        public virtual Article Article { get; set; }
        public decimal Amount { get; set; }
    }
}