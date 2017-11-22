using System;
using PersonalFinanceSite.Contracts.ApiLogicProviders;
using PersonalFinanceSite.Contracts.DatabaseContracts;
using PersonalFinanceSite.Db;

namespace PersonalFinanceSIte.Logic
{
    internal class UserLogicProvider : IUserLogicProvider
    {
        private PersonalFinanceSiteData db;

        public UserLogicProvider(PersonalFinanceSiteData db)
        {
            this.db = db;
        }

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