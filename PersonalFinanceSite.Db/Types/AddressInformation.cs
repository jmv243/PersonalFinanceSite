using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalFinanceSite.Contracts.DatabaseContracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalFinanceSite.Db.Types
{
    [Table("AddressInformation")]
    public class AddressInformation : IAddressInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid AddressInformationPK { get; set; }
        public Guid UserFK { get; set; }

        [MaxLength(256)]
        public string AddressLine1 { get; set; }

        [MaxLength(256)]
        public string AddressLine2 { get; set; }

        [MaxLength(256)]
        public string City { get; set; }

        [MaxLength(256)]
        public string State { get; set; }

        [MaxLength(16)]
        public string Zip { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
