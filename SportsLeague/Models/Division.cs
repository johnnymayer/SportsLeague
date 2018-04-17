using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SportsLeague.Models
{
    public class Division
    {
        [Key]
        public int divisionId { get; set; }
        public string divisionName { get; set; }
        public string divisionDescription { get; set; }
        public string divisionSkill { get; set; }
        public int maxTeamNumber { get; set; }
        public virtual ICollection<Division> Divisions { get; set; }
    }
}