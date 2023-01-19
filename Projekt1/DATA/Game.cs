using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1.DATA
{
    public class Game
    {
        [Key]
        public int GameID { get; set; }
        
        [Required]
        public int Score { get; set; }

        public double Wins { get; set; }

        public double GamesPlayed{ get; set; }

        public double AvarageScore { get; set; }
        
        [Required]
        public DateTime Date { get; set; }

    }
}
