using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using ProjectFinal1.Models;

namespace ProjectFinal1.Areas.Identity.Data;

// Add profile data for application users by adding properties to the AppilcationUser class
public class AppilcationUser : IdentityUser
{
    public int Codecoursetra { get; set; }
    [ForeignKey("Codecoursetra")]
    public virtual TraCourse TraCourse { get; set; }


    //[PersonalData]
    //[Column(TypeName = "nvarchar(100)")]
    //public string CourseCs { get; set; }
    [PersonalData]
    public int? CourseCsId { get; set; }

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
    public string Facebook { get; set; } 
    
    [PersonalData]
    [Column(TypeName = "nvarchar(100)")]
    public string Status { get; set; }
    [PersonalData]
    public string? FileName { get; set; }
    [PersonalData]
    public byte[]? FileContent { get; set; }


    [PersonalData]
    public string? FileName2 { get; set; }
    [PersonalData]
    public byte[]? FileContent2 { get; set; }
    [PersonalData]
    public int? Credit { get; set; }
}

