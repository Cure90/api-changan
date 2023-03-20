using System.ComponentModel.DataAnnotations.Schema;

namespace back_end.Data.Models {
    [Table("cat_status")]
    public class CatStatus {
        public int catStatusId { get; set; }
        public string description { get; set; }
        public bool isActive { get; set; }
        [Column("created_date")]
        public DateTime createdDate { get; set; } = DateTime.Now;
        [Column("updated_date")]
        public DateTime updatedDate { get; set; } = DateTime.Now;



    }
}
