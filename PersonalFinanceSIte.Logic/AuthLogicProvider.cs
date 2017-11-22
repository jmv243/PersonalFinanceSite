using System;
using PersonalFinanceSite.Contracts.ApiLogicProviders;
using PersonalFinanceSite.Contracts.Types;
using PersonalFinanceSite.Db;
using PersonalFinanceSite.Db.Types;
using System.Linq;
using System.Data.Entity;

namespace PersonalFinanceSIte.Logic
{
    public class AuthLogicProvider : IAuthLogicProvider
    {
        private PersonalFinanceSiteData db;
        private TokenGenerator tg;

        public AuthLogicProvider(PersonalFinanceSiteData db)
        {
            this.db = db;
            this.tg = new TokenGenerator();
        }

        public SessionData Login(LoginCredentials login)
        {
            User user = db.Users.Where(x => x.Email == login.EmailOrUserName || x.UserName == login.EmailOrUserName).FirstOrDefault();
            LoginInformation creds = db.LoginInformation.Where(x => x.UserFK == user.UserPK && x.Password == login.Password).FirstOrDefault();
            
            if(creds != default(LoginInformation))
            {
                return new SessionData()
                {
                    Token = tg.GenerateRandomToken(),
                    Valid = true,
                    ExpireDate = DateTime.UtcNow.AddHours(1),
                    CreatedDate = DateTime.UtcNow
                };
            }
            else
            {
                return new SessionData()
                {
                    Valid = false
                };
            }
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