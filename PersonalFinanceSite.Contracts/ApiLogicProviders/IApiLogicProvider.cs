using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinanceSite.Contracts.ApiLogicProviders
{
    /// <summary>
    /// Used to provide one interface that will allow the api access to the logic layer
    /// Each one of these will be used separately in an api controller
    /// </summary>
    public interface IApiLogicProvider
    {
        IAddressLogicProvider AddressLogicProvider { get; set; }
        IExpenseLogicProvider ExpenseLogicProvider { get; set; }
        IJobLogicProvider JobLogicProvider { get; set; }
        IAuthLogicProvider LoginLogicProvider { get; set; }
        IUserLogicProvider UserLogicProvider { get; set; }     
        ISignUpLogicProvider SignUpLogicProvider { get; set; }
    }
}
