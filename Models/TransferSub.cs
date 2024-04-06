using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectFinal1.Models
{
    public class TransferSub
    {
        [Key]
        public int CodeSubtrans { get; set; }
        public int CodeCoursetran { get; set; }
        public int Codecs { get; set; }
        public int Codetra { get; set; }
    }
}
