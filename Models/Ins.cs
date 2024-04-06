using System.ComponentModel.DataAnnotations;

namespace ProjectFinal1.Models
{
    public class Ins
    {
        [Key]
        public int InsCode { get; set; }
        public string InsName { get; set; }
    }
}
