using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectFinal1.Models;

namespace ProjectFinal1.DTOs
{
    public class PaireCoursePageDTO
    {
        //public List<SelectListItem> CourseCsTr { get; set; }
        public List<SelectListItem> CsCourse { get; set; }
        public List<SelectListItem> TraCourse { get; set; }
        public TransferCourse Data { get; set; }
    }
}
