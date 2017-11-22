using System;
using System.Collections.Generic;
using PersonalFinanceSite.Contracts.ApiLogicProviders;
using PersonalFinanceSite.Contracts.DatabaseContracts;
using PersonalFinanceSite.Db;

namespace PersonalFinanceSIte.Logic
{
    public class ExpenseLogicProvider : IExpenseLogicProvider
    {
        private PersonalFinanceSiteData db;

        public ExpenseLogicProvider(PersonalFinanceSiteData db)
        {
            this.db = db;
        }

        public void AddExpense(IExpense expense)
        {
            throw new NotImplementedException();
        }

        public IExpense DeleteExpense(Guid expensePK)
        {
            throw new NotImplementedException();
        }

        public IExpense GetExpenseByPK(Guid expensePK)
        {
            throw new NotImplementedException();
        }

        public List<IExpense> GetExpenses(Guid userFK)
        {
            throw new NotImplementedException();
        }

        public IExpense UpdateExpense(IExpense expense)
        {
            throw new NotImplementedException();
        }
    }
}