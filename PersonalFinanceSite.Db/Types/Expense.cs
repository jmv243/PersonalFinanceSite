using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalFinanceSite.Contracts.DatabaseContracts;
using PersonalFinanceSite.Contracts.Enums;

namespace PersonalFinanceSite.Db.Types
{
    public class Expense : IExpense
    {
        public Guid ExpensePK { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Guid UserFK { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ExpenseFrequency BillingFrequency { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PaymentDueDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime UpdatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
