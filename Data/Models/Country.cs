using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace back_end.Data.Models {
    public class Country {
        public Country() { 
            this.Neighborhoods = new HashSet<Neighborhood>();
            this.States = new HashSet<State>();
        }
        [Required]
        public int countryId { get; set; }
        public string countryName { get; set; }
        public State State { get; set; }
        [Column("is_active")]
        public bool isActive { get; set; }
        [Column("created_date")]
        public DateTime createdDate { get; set; } = DateTime.Now;
        [Column("updated_date")]
        public DateTime updatedDate { get; set; } = DateTime.Now;

        public virtual ICollection<Neighborhood> Neighborhoods { get; set; }
        public virtual ICollection<State> States { get; set; }
    }
}
