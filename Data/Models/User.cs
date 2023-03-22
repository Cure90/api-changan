using Npgsql.Internal.TypeMapping;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace back_end.Data.Models {
    public class User {
        public Guid userId { get; set; }
        [Column("user_name")]
        public string userName { get; set; }
        [Column("user_type")]
        public UserType UserType { get; set; }
        public string password { get; set; }
        [Column("is_active")]
        public bool isActive { get; set; }
        [Column("created_date")]
        public DateTime createdDate { get; set; } = DateTime.Now;

        public virtual UserInfo UserInfo { get; set; }
    }
}
