using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace back_end.Data.Models {
    public class State {
        public State() {
            this.Countries = new HashSet<Country>();
        }
        [Required]
        public int stateId { get; set; }
        public string stateName { get; set; }
        [Column("is_active")]
        public bool isActive { get; set; }
        [Column("created_date")]
        public DateTime createdDate { get; set; } = DateTime.Now;
        [Column("updated_date")]
        public DateTime updatedDate { get; set; } = DateTime.Now;

        public virtual ICollection<Country> Countries { get; set; }

    }
}
