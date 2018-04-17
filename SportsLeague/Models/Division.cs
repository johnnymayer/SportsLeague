using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsLeague.Models
{
    [Table("divisions")]
    public class Division
    {

        public Division()
        {
            this.Teams = new HashSet<Team>();
        }

        [Key]
        public int divisionId { get; set; }
        public string divisionName { get; set; }
        public string divisionDescription { get; set; }
        public string divisionSkill { get; set; }
        public int maxTeamNumber { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}