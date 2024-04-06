using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectFinal1.Models
{
    [Table("V_CourseTra", Schema = "dbo")]
    public class V_CourseTra
    {
        public V_CourseTra()
        {

        }
        [Key]
        public int Codetrasub { get; set; }
        public int Codecourse { get; set; }
        public string Namecoursetra { get; set; }

        public string Codesubtra { get; set; }
        public string Namethaitra { get; set; }
        public string Nameengtra { get; set; }
        public string Credittra { get; set; }
        public string Subdestra { get; set; }
        public string Status { get; set; }
    }
}
