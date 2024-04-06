using System.ComponentModel.DataAnnotations;

namespace ProjectFinal1.Models
{
    public class TraCourse
    {
        [Key]
        public int Codecoursetra { get; set; }
        public string Namecoursetra { get; set; }
        public string statuscoursetra { get; set; }
    }
}
