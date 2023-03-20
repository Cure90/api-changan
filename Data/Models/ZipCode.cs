using System.ComponentModel.DataAnnotations.Schema;

namespace back_end.Data.Models {
    public class ZipCode {

        public ZipCode() { 
            this.Neighborhoods = new HashSet<Neighborhood>();
        }
        public int zipCodeId { get; set; }
        public string zipCode { get; set; }
        [Column("is_active")]
        public bool isActive { get; set; }
        [Column("created_date")]
        public DateTime createdDate { get; set; } = DateTime.Now;
        [Column("updated_date")]
        public DateTime updatedDate { get; set; } = DateTime.Now;

        public virtual ICollection<Neighborhood> Neighborhoods { get; set; }
    }
}
