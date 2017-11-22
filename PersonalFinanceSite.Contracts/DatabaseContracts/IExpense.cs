using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalFinanceSite.Contracts.Enums;

namespace PersonalFinanceSite.Contracts.DatabaseContracts
{
    public interface IExpense
    {
        Guid ExpensePK { get; set; }
        Guid UserFK { get; set; }

        string Name { get; set; }
        ExpenseFrequency BillingFrequency { get; set; }
        string PaymentDueDate { get; set; }

        DateTime CreatedDate { get; set; }
        DateTime UpdatedDate { get; set; }
    }
}
