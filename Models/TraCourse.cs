using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectFinal1.Models
{
    public class TraCourse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Codecoursetra { get; set; }
        public string Namecoursetra { get; set; }
        public string statuscoursetra { get; set; }
    }
}
