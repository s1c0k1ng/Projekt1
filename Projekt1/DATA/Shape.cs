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
        public double input1 { get; set; }

        [Required]
        public double input2 { get; set; }
        
        [Required]
        public double input3 { get; set; }

        [Required]
        public double input4 { get; set; }
       
        [Required]
        public double input5 { get; set; }



        public double Area { get; set; }
        
        public double Perimeter { get; set; }

        public DateTime Date { get; set; }
       
    }
}
