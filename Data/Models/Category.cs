using System.ComponentModel.DataAnnotations.Schema;

namespace back_end.Data.Models {
    public class Category {

        public Category() {
            this.Models = new HashSet<Model>();
        }
        [Column("category_id")]
        public int categoryId { get; set; }
        [Column("category_name")]
        public string categoryName { get; set; }
        [Column("category_description")]
        public string? categoryDescription { get; set; }
        [Column("category_image")]
        public string? categoryImage { get; set; }
        [Column("is_active")]
        public bool isActive { get; set; } = true;
        [Column("created_date")]
        public DateTime createdDate { get; set; } = DateTime.Now;
        [Column("updated_date")]
        public DateTime updatedDate { get; set; } = DateTime.Now;

        public virtual ICollection<Model> Models { get; set; }
    }
}
