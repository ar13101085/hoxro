using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hoxro.Models
{
    [Table("BillingType", Schema = "bil")]
    public class BillingType
    {
        public int BillingTypeId { get; set; }
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsDefault { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}