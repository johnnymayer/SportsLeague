 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsLeague.Models
{
    [Table("Teams")]
    public class Team
    {
        public Team()
        {
            this.Players = new HashSet<Player>();
        }

        [Key]
        public int teamId { get; set; }
        public int divisionId { get; set; }
        public string teamName { get; set; }
        public virtual ICollection<Player> Players { get; set; }
        public virtual ICollection<Division> Divisions { get; set; }
    }
}
