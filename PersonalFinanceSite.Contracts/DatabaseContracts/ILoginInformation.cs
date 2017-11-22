using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinanceSite.Contracts.DatabaseContracts
{
    public interface ILoginInformation
    {
        Guid LoginInformationPK { get; set; }
        Guid UserFK { get; set; }

        string Password { get; set; }
        long LoginCounter { get; set; }
        long SubsequentFailedAttempts { get; set; }
        bool IsAccountLocked { get; set; }

        DateTime CreatedDate { get; set; }
        DateTime UpdatedDate { get; set; }
    }
}
