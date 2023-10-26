using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Domain.entities
{
    public class Namaste
    {


        [Key] 
        public int Id { get; set; }
        [MaxLength(50)]
        public required string Name { get; set; }
        public string? Description { get; set; }
        [Display(Name = "Price per night")]
        [Range(10,1000)]
        public double Price { get; set; }
        public int Sqft { get; set; } 
        [Range(1,15)]
        public int Occupancy { get; set; }
        [Display(Name = "Image Url")]
        public string? ImgUrl { get; set; }
        public DateTime? Created_Date { get; set; }
        public DateTime? Updated_Date { get; set; }
    }
}