using System;
using System.Collections.Generic;
using PersonalFinanceSite.Contracts.ApiLogicProviders;
using PersonalFinanceSite.Contracts.DatabaseContracts;
using NUnit.Framework;

namespace PersonalFinanceSIte.Logic
{
    public class JobLogicProviderTests : IJobLogicProvider
    {
        [Test]
        public void AddJob(IJob job)
        {
            throw new NotImplementedException();
        }

        [Test]
        public IJob DeleteJob(IJob job)
        {
            throw new NotImplementedException();
        }

        [Test]
        public IJob GetJobByPK(Guid jobPK)
        {
            throw new NotImplementedException();
        }

        [Test]
        public List<IExpense> GetJobs(Guid userFK)
        {
            throw new NotImplementedException();
        }

        [Test]
        public IJob UpdateJob(IJob job)
        {
            throw new NotImplementedException();
        }
    }
}