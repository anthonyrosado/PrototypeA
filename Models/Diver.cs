using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace PrototypeA.Models
{
    public class Diver
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }    

        public string email { get; set; }

        public ICollection<DiveLog> DiveLogs { get; set; }



        public Diver()
        {
            DiveLogs = new Collection<DiveLog>();
        }

    }
}
