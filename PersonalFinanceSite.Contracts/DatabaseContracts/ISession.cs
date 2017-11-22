using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinanceSite.Contracts.DatabaseContracts
{
    public interface ISession
    {
        Guid SessionPK { get; set; }

        string Token { get; set; }
        DateTime ExpireDate { get; set; }

        DateTime CreatedDate { get; set; }
        DateTime UpdatedDate { get; set; }
    }
}
