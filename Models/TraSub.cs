using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectFinal1.Models
{
    public class TraSub
    {
        [Key]
        public int Codesub { get; set; }
        [Display(Name = "TraCourse")]
        public int Codecourse { get; set; }
        [ForeignKey("Codecourse")]
        public virtual TraCourse TraCourse { get; set; }
        public string Codesubtra { get; set; }
        public string Namethaitra { get; set; }
        public string Nameengtra { get; set; }
        public string Credittra { get; set; }
        public string Subdestra { get; set; }
        public string Status { get; set; }
    }
}
