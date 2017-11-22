using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalFinanceSite.Contracts.DatabaseContracts;

namespace PersonalFinanceSite.Contracts.ApiLogicProviders
{
    public interface IJobLogicProvider
    {
        void AddJob(IJob job);
        IJob GetJobByPK(Guid jobPK);
        List<IExpense> GetJobs(Guid userFK);
        IJob UpdateJob(IJob job);
        IJob DeleteJob(IJob job);
    }
}
