using System.ComponentModel.DataAnnotations.Schema;

namespace back_end.Data.Models {
    [Table("agency_car")]
    public class AgencyCar {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int agencyCarId { get; set; }
        public Car Car { get; set; }
        public Agency Agency { get; set; }
        [Column("test_drive")]
        public bool testDrive { get; set; } = false;
        [Column("created_date")]
        public DateTime createdDate { get; set; } = DateTime.Now;
        [Column("updated_date")]
        public DateTime updatedDate { get; set; } = DateTime.Now;

        public virtual Inventory Inventory { get; set; }
    }
}
