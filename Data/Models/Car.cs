using System.ComponentModel.DataAnnotations.Schema;

namespace back_end.Data.Models {
    public class Car {

        [Column("car_id")]
        public int carId { get; set; }
        public Category category { get; set; }
        [Column("car_slug")]
        public string carSlug { get; set; }
        [Column("car_name")]
        public string carName { get; set; }
        [Column("shor_description")]
        public string? shorDescription { get; set;}
        [Column ("general_description")]
        public string? generalDescription { get; set; }
        [Column ("galery_general_description")]
        public string? galeryGeneralDescription { get; set; }
        public string? force { get; set; }
        [Column ("force_galery")]
        public string? forceGalery { get; set; }
        public string? confort { get; set; }
        [Column("confort_galery")]
        public string? confortGalery { get; set; }
        public string? smart { get; set; }
        [Column ("smart_gaery")]
        public string? smartGalery { get;set; }
        public string? security { get; set; }
        [Column("security_galery")]
        public string? securityGalery { get; set; }
        public string? myth { get; set; }
        [Column("myth_galery")]
        public string? mythGalery { get; set; }
        [Column("is_active")]
        public bool isActive { get; set; }
        [Column("created_date")]
        public DateTime createdDate { get; set; } = DateTime.Now;
        [Column("updated_date")]
        public DateTime updatedDate { get; set;} = DateTime.Now;
    }
}
