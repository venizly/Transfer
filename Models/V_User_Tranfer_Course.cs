using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectFinal1.Models
{
    [Table("V_User_Tranfer_Course", Schema = "dbo")]
    [Keyless]
    public class V_User_Tranfer_Course
    {
        public string Id { get; set; }
        public string? UserName { get; set; }
        public int? Codecoursetra { get; set; }
        public string? Namecoursetra { get; set; }
        public string? CourseCs { get; set; }
        public int? CourseCsId { get; set; }
        public int? CodeCoursetrans { get; set; }
        public string? Namethaitra { get; set; }
        public string? Namethaics { get; set; }
        public int? Codecoursecs { get; set; }
        public int? TransReCode { get; set; }
        
        [Range(2.00, 4.00, ErrorMessage = "เกรดต้องอยู่ระหว่าง 2.00 - 4.00")]
        [DisplayFormat(DataFormatString = "{0:0.00}", ApplyFormatInEditMode = true)]
        public decimal? GradeTra { get; set; }
        public int? CodeSubtrans { get; set; }
        public bool IsHide { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Codesubcs { get; set; }
        public string? Codesubtra { get; set; }
        public string? Credits { get; set; }
        public string? Credittra { get; set; }
        public int? TranferCredit { get; set; }

    }
}
