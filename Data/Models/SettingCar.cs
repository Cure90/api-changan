using System.ComponentModel.DataAnnotations.Schema;

namespace back_end.Data.Models {

    [Table("setting_car")]
    public class SettingCar {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int settingCarId { get; set; }
        public Car car { get; set; }
        [Column("setting_car_name")]
        public string? settingCarName { get; set; }
        public double price { get; set; }
        [Column("parameter_settings")]
        public string parameterSettings { get; set; }
        [Column("is_active")]
        public bool isActive { get; set; } = true;
        [Column("created_date")]
        public DateTime createdDate { get; set; } = DateTime.Now;
        [Column("updated_date")]
        public DateTime updatedDate { get; set;} = DateTime.Now;

    }
}
