using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectFinal1.Models
{
    [Table("V_CourseCsTra", Schema = "dbo")]
    public class V_CourseCsTra
    {
        public V_CourseCsTra()
        {

        }
        [Key]
        public int CodeCoursetrans { get; set; }
        public int CourseCs { get; set; }
        public string Namecoursecs { get; set; }

        public int CourseTra { get; set; }
        public string Namecoursetra { get; set; }
    }
}
