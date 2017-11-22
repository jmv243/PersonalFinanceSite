using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalFinanceSite.Contracts.DatabaseContracts;
using PersonalFinanceSite.Contracts.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalFinanceSite.Db.Types
{
    [Table("Expense")]
    public class Expense : IExpense
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid ExpensePK { get; set; }
        public Guid UserFK { get; set; }

        [MaxLength(256)]
        public string Name { get; set; }

        public ExpenseFrequency BillingFrequency { get; set; }

        [MaxLength(256)]
        public string PaymentDueDate { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
