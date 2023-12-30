using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace WebApplication1.Models
{
    public class Person
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int ID { get; set; }
        public string Name { get; set; }

        public string Race { get; set; }

        public string Gender { get; set; }

        public string ImgPath { get; set; }

        public string ImgFileName { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImgFile { get; set; }

        public Person()
        {

        }
    }
}
