using PersonalFinanceSite.Contracts.DatabaseContracts;
using PersonalFinanceSite.Contracts.Types;

namespace PersonalFinanceSite.Contracts.ApiLogicProviders
{
    public interface ISignUpLogicProvider
    {
        //returns sessionData and goes to the dashboard
        SessionData SignUp();
    }
}