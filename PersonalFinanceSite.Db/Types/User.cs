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
    [Table("User")]
    public class User : IUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid UserPK { get; set; }

        [MaxLength(256)]
        public string UserName { get; set; }

        [MaxLength(256)]
        public string FirstName { get; set; }

        [MaxLength(256)]
        public string LastName { get; set; }

        [MaxLength(256)]
        public string MiddleName { get; set; }

        [MaxLength(256)]
        public string Email { get; set; }
        
        public int Age { get; set; }

        [MaxLength(256)]
        public string Gender { get; set; }

        [MaxLength(256)]
        public string VeteranStatus { get; set; }

        [MaxLength(256)]
        public string Birthday { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
