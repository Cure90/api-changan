using System.ComponentModel.DataAnnotations.Schema;

namespace back_end.Data.Models {
    [Table("services_schedule")]
    public class ServicesSchedule {
        [Column("services_schedule_id")]
        public int servicesScheduleId { get; set; }
        public User User { get; set; }
        public Agency Agency { get; set; }
        [Column("model_year")]
        public int modelYear { get; set; }
        public Car Car { get; set; }
        public DateOnly schedule { get; set; }
        public int kilometers { get; set; }
        public string? comments { get; set; }
        public CatStatus CatStatus { get; set; }
        [Column("created_date")]
        public DateTime createdDate { get; set; } = DateTime.Now;
        [Column("updated_date")]
        public DateTime updatedDate { get; set; } = DateTime.Now;
    }
}
