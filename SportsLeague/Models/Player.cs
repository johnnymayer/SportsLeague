using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SportsLeague.Models
{
    public class Player
    {
        [Key]
        public int playerId { get; set; }
        public string playerName { get; set; }
        public int teamId { get; set; }
        public int captain { get; set; }
    }
}
