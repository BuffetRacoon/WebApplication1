using System.Drawing;

namespace WebApplication1.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Race { get; set; }

        public string Gender { get; set; }

        public Image img { get; set; }

        public Person()
        {

        }
    }
}
