using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectFinal1.Models
{
    public class CsCourse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Codecoursecs { get; set; }
        public string Namecoursecs { get; set; }
        public string statuscoursecs { get; set; }
    }
}
