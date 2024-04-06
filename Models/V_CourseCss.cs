using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectFinal1.Models
{
    [Table("V_CourseCss", Schema = "dbo")]
    public class V_CourseCss
    {
        public V_CourseCss()
        {

        }
        [Key]
        public int Codecssub { get; set; }
      
        public int Codecoursecs { get; set; }
        public string Namecoursecs { get; set; }
        public int Codesubgroup { get; set; }
        public string Namesubgroup { get; set; }
        public string Namesubtype { get; set; }


        public string Codesubcs { get; set; }
        public string Namethaics { get; set; }
        public string Nameengcs { get; set; }
        public string Credits { get; set; }
        public string Subdescs { get; set; }
        public string Status { get; set; }
    }
}
