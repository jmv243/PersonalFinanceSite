using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalFinanceSite.Contracts.DatabaseContracts;
using PersonalFinanceSite.Contracts.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalFinanceSite.Db.Types
{
    [Table("Job")]
    public class Job : IJob
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid JobPK { get; set; }
        public Guid UserFK { get; set; }

        [MaxLength(256)]
        public string JobTitle { get; set; }
        public PayType PaymentType { get; set; }
        public double PayCheckAmount { get; set; }
        public PayFrequency PayCheckFrequency { get; set; }

        [MaxLength(256)]
        public string CompanyName { get; set; }

        [MaxLength(256)]
        public string CompanyCity { get; set; }

        [MaxLength(256)]
        public string Industry { get; set; }
        public int YearlySalary { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
