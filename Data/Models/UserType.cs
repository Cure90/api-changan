using System.ComponentModel.DataAnnotations.Schema;

namespace back_end.Data.Models {
    [Table("cat_user_type")]
    public class UserType {

        [Column("cat_user_type_id")]
        public int userTypeId { get; set; }
        [Column("user_type")]
        public string userType { get; set; }
        [Column("is_active")]
        public bool isActive { get; set; }
        [Column("created_date")]
        public DateTime createdDate { get; set; } = DateTime.Now;
        [Column("updated_date")]
        public DateTime updatedDate { get; set; } = DateTime.Now;

    }
}
