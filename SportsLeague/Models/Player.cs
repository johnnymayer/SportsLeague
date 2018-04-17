using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsLeague.Models
{
    [Table("Players")]
    public class Player
    {

        [Key]
        public int playerId { get; set; }
        public string playerName { get; set; }
        public int teamId { get; set; }
        public int divisionId { get; set; }
        public int captain { get; set; }
        public virtual Team Team { get; set; }
    }
}
