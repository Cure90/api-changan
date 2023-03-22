using System.ComponentModel.DataAnnotations.Schema;

namespace back_end.Data.Models {
    [Table("cat_email_type")]
    public class EmailType {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int emailTypeId { get; set; }
        public string name { get; set; }
        public string listTo { get; set; }
        [Column("is_active")]
        public bool isActive { get; set; }
        [Column("created_date")]
        public DateTime createdDate { get; set; } = DateTime.Now;
        [Column("updated_date")]
        public DateTime updatedDate { get; set; } = DateTime.Now;
    }
}
