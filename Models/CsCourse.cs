using System.ComponentModel.DataAnnotations;

namespace ProjectFinal1.Models
{
    public class CsCourse
    {
        [Key]
        public int Codecoursecs { get; set; }
        public string Namecoursecs { get; set; }
        public string statuscoursecs { get; set; }
    }
}
