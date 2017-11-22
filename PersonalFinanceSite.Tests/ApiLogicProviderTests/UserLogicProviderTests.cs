using System;
using PersonalFinanceSite.Contracts.ApiLogicProviders;
using PersonalFinanceSite.Contracts.DatabaseContracts;
using NUnit.Framework;

namespace PersonalFinanceSIte.Logic
{
    internal class UserLogicProviderTests : IUserLogicProvider
    {
        [Test]
        public IUser Add(IUser user)
        {
            throw new NotImplementedException();
        }

        [Test]
        public IUser DeactivateUser(Guid userPK)
        {
            throw new NotImplementedException();
        }

        [Test]
        public IUser GetUser(Guid userPK)
        {
            throw new NotImplementedException();
        }

        [Test]
        public IUser UpdateUser(IUser user)
        {
            throw new NotImplementedException();
        }
    }
}