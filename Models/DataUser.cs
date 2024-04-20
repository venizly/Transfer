using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectFinal1.Models
{
    [Table("AspNetUsers", Schema = "dbo")]
    public class DataUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Transcode { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string FirstName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }
        
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string CourseCs { get; set; }

        //[PersonalData]
        //[Display(Name = "Ins")]
        //public int InsCode { get; set; }
        //[ForeignKey("InsCode")]
        //public virtual Ins Ins { get; set; }
        [PersonalData]
        [Display(Name = "TraCourse")]
        public int Codecoursetra { get; set; }
        [ForeignKey("Codecoursetra")]
        public virtual TraCourse TraCourse { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Facebook { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Status { get; set; }
        [NotMapped]
        public bool HaveTranfer { get; set; }
        [PersonalData]
        public string? FileName { get; set; }
        [PersonalData]
        public byte[]? FileContent { get; set; }

        [PersonalData]
        public string? FileName2 { get; set; }
        [PersonalData]
        public byte[]? FileContent2 { get; set; }

    }
}
