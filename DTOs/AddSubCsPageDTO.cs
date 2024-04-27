using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectFinal1.Models;

namespace ProjectFinal1.DTOs
{
    public class AddSubCsPageDTO
    {
        public List<SelectListItem> CsCourse { get; set; }
        public List<SelectListItem> CsSubgroup { get; set; }
        public CsCourseStruc Data { get; set; }
    }
}
