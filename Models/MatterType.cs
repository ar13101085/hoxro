using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hoxro.Models
{
    [Table("MatterType", Schema = "mtr")]
    public class MatterType
    {
        public int MatterTypeId { get; set; }
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public bool IsDeleted { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        
    }
}