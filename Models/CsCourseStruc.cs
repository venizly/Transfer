using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectFinal1.Models
{
    public class CsCourseStruc
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Codecssub { get; set; }
        public int Codecoursecs { get; set; }
        public int Codesubgroup { get; set; }
        public string Codesubcs { get; set; }
        public string Namethaics { get; set; }
        public string Nameengcs { get; set; }
        public string Credits { get; set; }
        public string Subdescs { get; set; }
        public string Status { get; set; }

    }
}
