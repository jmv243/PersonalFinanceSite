using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinanceSite.Contracts.Types
{
    public class SessionData
    {
        string Token { get; set; }
        DateTime ExpireDate { get; set; }
        DateTime CreatedDate { get; set; }
    }
}
