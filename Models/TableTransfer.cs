using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public bool? IsHide { get; set; }
        [ForeignKey("UserId")]
        public virtual DataUser User { get; set; }


    }
}
