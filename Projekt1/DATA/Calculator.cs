using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1.DATA
{
    public class Calculator
    {
        [Key]
        public int CalculatorID { get; set; }

        [Required]
        public string CalculationMethod { get; set; }

        [Required]
        public double FirstNumb { get; set; }
       
        [Required]
        public double SecondNumb { get; set; }

      
        public double Sum { get; set; }

        public double Sum2 { get; set; }



        public DateTime Date { get; set; }

    }
}
