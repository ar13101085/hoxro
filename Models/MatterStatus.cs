using System.ComponentModel.DataAnnotations.Schema;

namespace Hoxro.Models
{
    [Table("MatterStatus", Schema = "mtr")]
    public class MatterStatus
    {
        public int MatterStatusId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}