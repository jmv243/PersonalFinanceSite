using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalFinanceSite.Contracts.DatabaseContracts;

namespace PersonalFinanceSite.Db.Types
{
    public class AddressInformation : IAddressInformation
    {
        public Guid AddressInformationPK { get; set; }
        public Guid UserFK { get; set; }

        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
