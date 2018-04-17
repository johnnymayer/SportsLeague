using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsLeague.Models
{
    public class Team
    {
        [Key]
        public int teamId { get; set; }
        public int divisionId { get; set; }
        public string teamName { get; set; }
        public virtual ICollection<Player> Players { get; set; }
    }
}
