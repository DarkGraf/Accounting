using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccountingWebMvc.Dal.Entities
{
    public class FinancialStore
    {
        public FinancialStore()
        {
            Inventories = new List<Inventory>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [StringLength(25)]
        public string Name { get; set; }
        public virtual ICollection<Inventory> Inventories { get; set; }
    }
}
