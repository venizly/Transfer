using System.ComponentModel.DataAnnotations;

namespace ProjectFinal1.Models
{
    public class CsSubtype
    {
        [Key]
        public int Codesubtype {  get; set; }
        public string Namesubtype { get; set; }
        public string Credit { get; set; }
    }
}
