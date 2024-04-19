using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectFinal1.Models
{
    public class TransferCourse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CodeCoursetrans { get; set; }
        public int Coursecs { get; set; }
        public int Coursetra { get; set; }
    }
}
