using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalFinanceSite.Contracts.ApiLogicProviders;
using PersonalFinanceSite.Db;

namespace PersonalFinanceSIte.Logic
{
    /// <summary>
    /// Centralized logic provider to reduce code copy
    /// </summary>
    public class ApiLogicProvider : IApiLogicProvider
    {
        public IAddressLogicProvider AddressLogicProvider { get; set; }
        public IExpenseLogicProvider ExpenseLogicProvider { get; set; }
        public IJobLogicProvider JobLogicProvider { get; set; }
        public IAuthLogicProvider LoginLogicProvider { get; set; }
        public IUserLogicProvider UserLogicProvider { get; set; }
        public ISignUpLogicProvider SignUpLogicProvider { get; set; }

        public ApiLogicProvider()
        {
            PersonalFinanceSiteData db = new PersonalFinanceSiteData();

            AddressLogicProvider = new AddressLogicProvider(db);
            ExpenseLogicProvider = new ExpenseLogicProvider(db);
            JobLogicProvider = new JobLogicProvider(db);
            LoginLogicProvider = new AuthLogicProvider(db);
            UserLogicProvider = new UserLogicProvider(db);
            SignUpLogicProvider = new SignUpLogicProvider(db);
        }
    }
}
