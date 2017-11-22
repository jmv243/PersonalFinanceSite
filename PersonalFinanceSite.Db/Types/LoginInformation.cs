using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalFinanceSite.Contracts.DatabaseContracts;

namespace PersonalFinanceSite.Db.Types
{
    public class LoginInformation : ILoginInformation
    {
        public Guid LoginInformationPK { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Guid UserFK { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public long LoginCounter { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public long SubsequentFailedAttempts { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsAccountLocked { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime UpdatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
