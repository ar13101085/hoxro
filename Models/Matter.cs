using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hoxro.Models
{
    [Table("Matter", Schema = "mtr")]
    public class Matter
    {
        public int MatterId { get; set; }
        public string MatterGuid { get; set; }
        public int CompanyId { get; set; }
        public int ClientId { get; set; }
        public string MatterRef { get; set; }
        public int MatterStatusId { get; set; }
        public int MatterChildStatusId { get; set; }
        public int StateId { get; set; }
        public int Biller { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string SerialNumber { get; set; }
        public int? SystemSerialNumber { get; set; }
        public int WorkTypeId { get; set; }
        public bool IsDeleted { get; set; }
    }
}