using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectFinal1.Models;

namespace ProjectFinal1.DTOs
{
    public class AddSubTraPageDTO
    {
        public List<SelectListItem> TraCourse { get; set; }
        public TraSub Data { get; set; }
    }
}
