using System.ComponentModel.DataAnnotations.Schema;

namespace back_end.Data.Models {
    public class Model {

        public Model() {
            this.Categories = new HashSet<Category>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int modelId { get; set; }
        [Column("model_name")]
        public string modelName { get; set; }
        [Column("model_description")]
        public string? modelDescription { get; set; }
        [Column("model_image")]
        public string? modelImage { get; set; }
        [Column("is_active")]
        public bool isActive { get; set; } = true;
        [Column("created_date")]
        public DateTime createdDate { get; set; } = DateTime.Now;
        [Column("updated_date")]
        public DateTime updatedDate { get; set; } = DateTime.Now;

        public virtual ICollection<Category> Categories { get; set;}
    }
}
