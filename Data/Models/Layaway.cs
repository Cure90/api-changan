using System.ComponentModel.DataAnnotations.Schema;

namespace back_end.Data.Models {
    public class Layaway {
        public int layawayId { get; set; }
        public User User { get; set; }
        public Agency Agency { get; set; }
        public Car Car { get; set; }
        public double amount { get; set; }
        public string folio { get; set; }
        public string? comments { get; set; }
        public CatStatus CatStatus { get; set; }
        [Column("created_date")]
        public DateTime createdDate { get; set; } = DateTime.Now;
        [Column("updated_date")]
        public DateTime updatedDate { get; set; } = DateTime.Now;
    }
}
