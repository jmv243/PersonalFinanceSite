using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalFinanceSite.Contracts.ApiLogicProviders;
using PersonalFinanceSite.Contracts.DatabaseContracts;
using NUnit.Framework;
using PersonalFinanceSite.Contracts.Types;

namespace PersonalFinanceSite.Tests
{
    class AuthLogicProviderTests : IAuthLogicProvider
    {
        [Test]
        public SessionData Login(LoginCredentials login)
        {
            throw new NotImplementedException();
        }

        [Test]
        public void LogOut(SessionData session)
        {
            throw new NotImplementedException();
        }

        [Test]
        public SessionData ValidateSessionData(SessionData session)
        {
            throw new NotImplementedException();
        }
    }
}
