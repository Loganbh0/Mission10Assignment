using System.ComponentModel.DataAnnotations;

namespace Mission10Assignment.Data
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }

        [Required]
        public string TeamName { get; set; } = string.Empty;

        public int? CaptainID { get; set; }

        public ICollection<Bowler> Bowlers { get; set; } = new List<Bowler>();
    }
}
