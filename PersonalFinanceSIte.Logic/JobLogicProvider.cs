using System;
using System.Collections.Generic;
using PersonalFinanceSite.Contracts.ApiLogicProviders;
using PersonalFinanceSite.Contracts.DatabaseContracts;

namespace PersonalFinanceSIte.Logic
{
    public class JobLogicProvider : IJobLogicProvider
    {
        public void AddJob(IJob job)
        {
            throw new NotImplementedException();
        }

        public IJob DeleteJob(IJob job)
        {
            throw new NotImplementedException();
        }

        public IJob GetJobByPK(Guid jobPK)
        {
            throw new NotImplementedException();
        }

        public List<IExpense> GetJobs(Guid userFK)
        {
            throw new NotImplementedException();
        }

        public IJob UpdateJob(IJob job)
        {
            throw new NotImplementedException();
        }
    }
}