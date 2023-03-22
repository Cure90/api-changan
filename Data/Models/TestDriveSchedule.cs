using System.ComponentModel.DataAnnotations.Schema;

namespace back_end.Data.Models {
    [Table("test_drive_schedule")]
    public class TestDriveSchedule {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int testDriveScheduleId { get; set; }
        public User User { get; set; }
        public Agency Agency { get; set; }
        [Column("model_year")]
        public int modelYear { get; set; }
        public Car Car { get; set; }
        public DateOnly schedule { get; set; }
        public string? comments { get; set; }
        public CatStatus CatStatus { get; set; }
        [Column("created_date")]
        public DateTime createdDate { get; set; } = DateTime.Now;
        [Column("updated_date")]
        public DateTime updatedDate { get; set; } = DateTime.Now;
    }
}
