using System;
using System.Collections.Generic;
using PersonalFinanceSite.Contracts.ApiLogicProviders;
using PersonalFinanceSite.Contracts.DatabaseContracts;
using PersonalFinanceSite.Db;

namespace PersonalFinanceSIte.Logic
{
    public class JobLogicProvider : IJobLogicProvider
    {
        private PersonalFinanceSiteData db;

        public JobLogicProvider(PersonalFinanceSiteData db)
        {
            this.db = db;
        }

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