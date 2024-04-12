﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectFinal1.Models
{
    [Table("V_User_Tranfer_Course", Schema = "dbo")]
    public class V_User_Tranfer_Course
    {
        [Key]
        public string Id { get; set; }
        public string UserName { get; set; }
        public int Codecoursetra { get; set; }
        public string Namecoursetra { get; set; }
        public string CourseCs { get; set; }
        public int CodeCoursetrans { get; set; }
        public string Namethaitra { get; set; }
        public string Namethaics { get; set; }
        public int Codecoursecs { get; set; }
        public int? TransReCode { get; set; }
        public string? GradeTra { get; set; }
        public int? CodeSubtrans { get; set; }
        public bool IsHide { get; set; }
    }
}
