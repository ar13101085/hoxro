using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hoxro.Models
{
    [Table("MatterChildStatus", Schema = "mtr")]
    public class MatterChildStatus
    {
        public int MatterChildStatusId { get; set; }
        public int MatterParentStatusId { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDefault { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IsLead { get; set; }
        public bool? IsOpen { get; set; }
        public bool? IsClosed { get; set; }
    }
}