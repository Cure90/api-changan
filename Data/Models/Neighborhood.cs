using System.ComponentModel.DataAnnotations.Schema;

namespace back_end.Data.Models {
    public class Neighborhood {
        public Neighborhood() {
            this.ZipCodes = new HashSet<ZipCode>();
            this.Countries = new HashSet<Country>();
        }
        public int neightborhoodId { get; set; }
        public string neightborhoodName { get; set; }
        [Column("is_active")]
        public bool isActive { get; set; }
        [Column("created_date")]
        public DateTime createdDate { get; set; } = DateTime.Now;
        [Column("updated_date")]
        public DateTime updatedDate { get; set; } = DateTime.Now;

        public virtual ICollection<ZipCode> ZipCodes { get; set; }
        public virtual ICollection<Country> Countries { get; set; }
    }
}
