using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Domain.entities
{
    public class NamasteNumber
    {
         [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
       
        public int Namaste_Number { get; set; }
        [ForeignKey("Namaste")]
        public int NamasteId { get; set; }
        public Namaste Namaste { get; set; }
        public string? SpecialDetails { get; set; }

        
       

    }
}
