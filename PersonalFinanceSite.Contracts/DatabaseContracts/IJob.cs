using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalFinanceSite.Contracts.Enums;

namespace PersonalFinanceSite.Contracts.DatabaseContracts
{
    public interface IJob
    {
        Guid JobPK { get; set; }
        Guid UserFK { get; set; }

        string JobTitle { get; set; }
        PayType PaymentType { get; set; }
        double PayCheckAmount { get; set; } 
        PayFrequency PayCheckFrequency { get; set; }
        string CompanyName { get; set; }
        string CompanyCity { get; set; }
        string Industry { get; set; }
        int YearlySalary { get; set; }

        DateTime CreatedDate { get; set; }
        DateTime UpdatedDate { get; set; }
    }
}
