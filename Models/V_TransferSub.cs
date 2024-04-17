using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectFinal1.Models
{
    [Table("V_TransferSub", Schema = "dbo")]
    public class V_TransferSub
    {
        public V_TransferSub()
        {

        }
        [Key]
        public int CodeSubtrans { get; set; }
        public int CodeCoursetran { get; set; }
        public int Coursecs { get; set; }
        public string Namecoursecs { get; set; }
        public int Codecs { get; set; }
        public string Codesubcs { get; set; }
        public string Namethaics { get; set; }
        public string Subdescs { get; set; }


        public int Coursetra { get; set; }
        public string Namecoursetra { get; set; }
        public int Codetra { get; set; }
        public string Codesubtra { get; set; }
        public string Namethaitra { get; set; }
        public string Subdestra { get; set; }
    }
}
