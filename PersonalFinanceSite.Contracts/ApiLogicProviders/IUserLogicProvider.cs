using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalFinanceSite.Contracts.DatabaseContracts;
using PersonalFinanceSite.Contracts.Types;

namespace PersonalFinanceSite.Contracts.ApiLogicProviders
{
    public interface IUserLogicProvider
    {
        IUser Add(IUser user);
        IUser GetUser(Guid userPK);
        IUser UpdateUser(IUser user);
        IUser DeactivateUser(Guid userPK);
    }
}
