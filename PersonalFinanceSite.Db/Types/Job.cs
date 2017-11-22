using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalFinanceSite.Contracts.DatabaseContracts;
using PersonalFinanceSite.Contracts.Enums;

namespace PersonalFinanceSite.Db.Types
{
    public class Job : IJob
    {
        public Guid JobPK { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Guid UserFK { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string JobTitle { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public PayType PaymentType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double PayCheckAmount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public PayFrequency PayCheckFrequency { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CompanyName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CompanyCity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Industry { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int YearlySalary { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime UpdatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
