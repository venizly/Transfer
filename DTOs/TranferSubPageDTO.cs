using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectFinal1.Models;

namespace ProjectFinal1.DTOs
{
    public class TranferSubPageDTO
    {
        public int Id { get; set; }
        public int Codecs { get; set; }
        public int Codetra { get; set; }
        public List<SelectListItem> CsCourseStruc { get; set; }
        public List<SelectListItem> TraSub { get; set; }
        public List<V_TransferSub> DataTable { get; set; }
    }
}
