using System.ComponentModel.DataAnnotations;

namespace ProjectFinal1.Models
{
    public class TableTransfer
    {
        [Key]
        public int TransReCode { get; set; }
        public string? Transcode { get; set; }
        public int CodeSubtran { get; set; }
        public string? GradeTra {  get; set; }
        public string? UserId { get; set; }
    }
}
