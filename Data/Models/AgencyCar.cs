using System.ComponentModel.DataAnnotations.Schema;

namespace back_end.Data.Models {
    [Table("ageny_car")]
    public class AgencyCar {
        [Column("agency_car_id")]
        public int agencyCarId { get; set; }
        public Car Car { get; set; }
        [Column("agency_id")]
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
