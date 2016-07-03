using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccountingWebMvc.Dal.Entities
{
    public class Inventory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public Guid StoreId { get; set; }
        [ForeignKey("StoreId")]
        public virtual FinancialStore FinancialStore { get; set; }
        public decimal Amount { get; set; }
    }
}