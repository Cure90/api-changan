using System.ComponentModel.DataAnnotations.Schema;

namespace back_end.Data.Models {
    public class Inventory {
        
        [ForeignKey("AgencyCar")]
        [Column("agency_car_id")]
        public int agencyCar { get; set; }
        [Column("count_test_drive")]
        public int countTestDrive { get; set; } = 0;
        [Column("count_layaway")]
        public int countLayaway { get; set; } = 0;
        [Column("created_date")]
        public DateTime createdDate { get; set; } = DateTime.Now;
        [Column("updated_date")]
        public DateTime updatedDate { get; set; } = DateTime.Now;
        public virtual AgencyCar AgencyCar { get; set; }
    }
}
