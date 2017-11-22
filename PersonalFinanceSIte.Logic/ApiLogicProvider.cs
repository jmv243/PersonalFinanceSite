using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalFinanceSite.Contracts.ApiLogicProviders;

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
            AddressLogicProvider = new AddressLogicProvider();
            ExpenseLogicProvider = new ExpenseLogicProvider();
            JobLogicProvider = new JobLogicProvider();
            LoginLogicProvider = new AuthLogicProvider();
            UserLogicProvider = new UserLogicProvider();
            SignUpLogicProvider = new SignUpLogicProvider();
        }
    }
}
