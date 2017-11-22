using System;
using PersonalFinanceSite.Contracts.ApiLogicProviders;
using PersonalFinanceSite.Contracts.Types;

namespace PersonalFinanceSIte.Logic
{
    public class LoginLogicProvider : IAuthLogicProvider
    {
        public SessionData Login(LoginCredentials login)
        {
            throw new NotImplementedException();
        }

        public void LogOut(SessionData session)
        {
            throw new NotImplementedException();
        }

        public SessionData ValidateSessionData(SessionData session)
        {
            throw new NotImplementedException();
        }
    }
}