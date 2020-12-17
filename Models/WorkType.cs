using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hoxro.Models
{
    [Table("WorkType", Schema = "mtr")]
    public class WorkType
    {
        public int WorkTypeId { get; set; }
        public string Name { get; set; }
        public int MatterTypeId { get; set; }
        public bool IsDeleted { get; set; }
        public int CompanyId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool? IsConflictCheck { get; set; }
        public bool? IsAmlcheck { get; set; }
        public bool? IsIdcheck { get; set; }
        public int? MatterPracticeTypeId { get; set; }
        public bool? IsLegalAid { get; set; }
        public string Tags { get; set; }
        public string Description { get; set; }
    }
}