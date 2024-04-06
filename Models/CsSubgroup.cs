using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectFinal1.Models
{
    public class CsSubgroup
    {
        [Key]
        public int Codesubgroup { get; set; }
        [Display(Name = "CsSubtype")]
        public int Codesubtype { get; set; }
        [ForeignKey("Codesubtype")]
        public virtual CsSubtype CsSubtype { get; set; }
        public string Namesubgroup { get; set; }
        public string Credit { get; set; }
    }
}
