using System.ComponentModel.DataAnnotations.Schema;

namespace back_end.Data.Models {
    [Table("email_template")]
    public class EmailTemplate {
        public int emailTemplateId { get; set; }
        public EmailType EmailType { get; set; }
        public string? emailName { get; set; }
        public string? subject { get; set; }
        public string template { get; set; }
        public string? description { get; set; }
        [Column("is_active")]
        public bool isActive { get; set; }
        [Column("created_date")]
        public DateTime createdDate { get; set; } = DateTime.Now;
        [Column("updated_date")]
        public DateTime updatedDate { get; set; } = DateTime.Now;

    }
}
