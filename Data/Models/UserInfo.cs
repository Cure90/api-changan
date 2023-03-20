using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace back_end.Data.Models {
    [Table("user_info")]
    public class UserInfo {
        [Key]
        [Column("user_info_id")]
        public int userInfoId { get; set; }
        [ForeignKey("User")]
        public Guid userId { get; set; }
        [Column("agencyId")]
        public int? agencyId { get; set; } = null;
        public string name { get; set; }
        public DateOnly birthday { get; set; }
        public string email { get; set; }
        [Column("cell_phone")]
        public string cellPhome { get; set; }
        public string address { get; set; }
        public string state { get; set; }
        public string zipcode { get; set; }
        public string country { get; set; }
        public string neighborhood { get; set; }
        [Column("created_date")]
        public DateTime createdDate { get; set; } = DateTime.Now;
        [Column("updated_date")]
        public DateTime updatedDate { get; set; } = DateTime.Now;

        public virtual User User { get; set; }
    }
}
