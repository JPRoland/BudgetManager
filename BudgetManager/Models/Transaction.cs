using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetManager.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "decimal(19,4)")]
        public decimal TransactionAmount { get; set; }

        [Required]
        public string Memo { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }

        public int AccountId { get; set; }
        public virtual Account Account { get; set; }
    }
}
