using System;
using PersonalFinanceSite.Contracts.ApiLogicProviders;
using PersonalFinanceSite.Contracts.Types;
using PersonalFinanceSite.Db;

namespace PersonalFinanceSIte.Logic
{
    public class AuthLogicProvider : IAuthLogicProvider
    {
        private PersonalFinanceSiteData db;

        public AuthLogicProvider(PersonalFinanceSiteData db)
        {
            this.db = db;
        }

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