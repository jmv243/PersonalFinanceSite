using System;
using PersonalFinanceSite.Contracts.ApiLogicProviders;
using PersonalFinanceSite.Contracts.Types;
using PersonalFinanceSite.Db;

namespace PersonalFinanceSIte.Logic
{
    public class SignUpLogicProvider : ISignUpLogicProvider
    {
        private PersonalFinanceSiteData db;

        public SignUpLogicProvider(PersonalFinanceSiteData db)
        {
            this.db = db;
        }

        public SessionData SignUp()
        {
            throw new NotImplementedException();
        }
    }
}