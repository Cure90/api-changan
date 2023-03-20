namespace back_end.Data.Models {
    public class Contact {
        public int contactId { get; set; } 
        public string name { get; set; }
        public string cellPhone { get; set; }
        public string email { get; set; }
        public string coments { get; set; }
        public bool active { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime updatedDate { get; set; } 
    }
}
