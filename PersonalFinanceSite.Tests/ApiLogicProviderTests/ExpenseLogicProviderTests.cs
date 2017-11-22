using System;
using System.Collections.Generic;
using PersonalFinanceSite.Contracts.ApiLogicProviders;
using PersonalFinanceSite.Contracts.DatabaseContracts;
using NUnit.Framework;

namespace PersonalFinanceSIte.Logic
{
    public class ExpenseLogicProviderTests : IExpenseLogicProvider
    {
        [Test]
        public void AddExpense(IExpense expense)
        {
            throw new NotImplementedException();
        }

        [Test]
        public IExpense DeleteExpense(Guid expensePK)
        {
            throw new NotImplementedException();
        }

        [Test]
        public IExpense GetExpenseByPK(Guid expensePK)
        {
            throw new NotImplementedException();
        }

        [Test]
        public List<IExpense> GetExpenses(Guid userFK)
        {
            throw new NotImplementedException();
        }

        [Test]
        public IExpense UpdateExpense(IExpense expense)
        {
            throw new NotImplementedException();
        }
    }
}