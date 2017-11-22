using PersonalFinanceSite.Contracts.DatabaseContracts;
using PersonalFinanceSite.Contracts.Types;

namespace PersonalFinanceSite.Contracts.ApiLogicProviders
{
    public interface IAuthLogicProvider
    {
        SessionData Login(LoginCredentials login);
        void LogOut(SessionData session);
        SessionData ValidateSessionData(SessionData session);
    }
}