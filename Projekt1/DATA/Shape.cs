using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1.DATA
{
    public class Shape
    {
        [Key]
        public int ShapeID { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public double Area { get; set; }
        
        [Required]
        public double Perimeter { get; set; }

        public DateTime Date { get; set; }
       
    }
}
