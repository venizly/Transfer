using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectFinal1.Models
{
    public class AppFile
    {
        [Key]
        public int Id { get; set; }
        public string FileName { get; set; }
        public string Transcode { get; set; }
        public byte[] Content { get; set; }
        
    }
    public class FileViewModel
    {
        public IFormFile FormFile { get; set; }
    }
}