using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinanceSite.Contracts.DatabaseContracts
{
    public interface IUser
    {
        Guid UserPK { get; set; }

        string UserName { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string MiddleName { get; set; }
        string Email { get; set; }
        int Age { get; set; }
        string Gender { get; set; }
        string VeteranStatus { get; set; }
        string Birthday { get; set; }

        DateTime CreatedDate { get; set; }
        DateTime UpdatedDate { get; set; }
    }
}
