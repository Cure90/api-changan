using System.ComponentModel.DataAnnotations.Schema;

namespace back_end.Data.Models {
    public class Agency {
        [Column("agency_id")]
        public int agencyId { get; set; }
        [Column("agency_name")]
        public string agencyName { get; set; }
        [Column("agency_description")]
        public string? agencyDescription { get; set; }
        public string? location { get; set; }
        [Column("test_drive")]
        public bool testDrive { get; set; }
        [Column("layaway_system")]
        public bool layawaySystem { get; set; }
        public bool services { get; set; }
        [Column("is_active")]
        public bool isActive { get; set; }
        [Column("created_date")]
        public DateTime createdDate { get; set; } = DateTime.Now;
        [Column("updated_date")]
        public DateTime updatedDate { get; set; } = DateTime.Now;
    }
}
