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
    [Table("LoginInformation")]
    public class LoginInformation : ILoginInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid LoginInformationPK { get; set; }
        public Guid UserFK { get; set; }

        [MaxLength(256)]
        public string Password { get; set; }
        public long LoginCounter { get; set; }
        public long SubsequentFailedAttempts { get; set; }
        public bool IsAccountLocked { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
