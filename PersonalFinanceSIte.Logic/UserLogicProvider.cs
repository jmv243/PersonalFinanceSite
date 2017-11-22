using System;
using PersonalFinanceSite.Contracts.ApiLogicProviders;
using PersonalFinanceSite.Contracts.DatabaseContracts;

namespace PersonalFinanceSIte.Logic
{
    internal class UserLogicProvider : IUserLogicProvider
    {
        public IUser Add(IUser user)
        {
            throw new NotImplementedException();
        }

        public IUser DeactivateUser(Guid userPK)
        {
            throw new NotImplementedException();
        }

        public IUser GetUser(Guid userPK)
        {
            throw new NotImplementedException();
        }

        public IUser UpdateUser(IUser user)
        {
            throw new NotImplementedException();
        }
    }
}