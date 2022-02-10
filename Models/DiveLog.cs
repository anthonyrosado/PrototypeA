using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrototypeA.Models
{
    public class DiveLog
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        
        public DateTime DateTime { get; set; } = DateTime.Now;

        
        [StringLength(255)]

        public string Location { get; set; }



        public float Si { get; set; }



        public char StartPg { get; set; }



        public float AirIn { get; set; }


        public int Depth { get; set; }



        public int Time { get; set; }



        public int visibility { get; set; }



        public float AirOut { get; set; }



        public int Weight { get; set; }



        public char EndPg { get; set; }



   

    }
}
