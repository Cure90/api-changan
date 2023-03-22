using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace back_end.Data.Models {
    public class State {

        public State() {
            this.Countries = new HashSet<Country>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int stateId { get; set; }
        public string stateName { get; set; }
        [Column("is_active")]
        public bool isActive { get; set; }
        [Column("created_date")]
        public DateTime createdDate { get; set; } = DateTime.Now;
        [Column("updated_date")]
        public DateTime updatedDate { get; set; } = DateTime.Now;

        public virtual ICollection<Country> Countries { get; set; }

    }

    public class Country {

        public Country() {
            this.States = new HashSet<State>();
            this.Neighborhoods = new HashSet<Neighborhood>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int countryId { get; set; }
        public string countryName { get; set; }
        [Column("is_active")]
        public bool isActive { get; set; }
        [Column("created_date")]
        public DateTime createdDate { get; set; } = DateTime.Now;
        [Column("updated_date")]
        public DateTime updatedDate { get; set; } = DateTime.Now;

        public virtual ICollection<State> States { get; set; }
        public virtual ICollection<Neighborhood> Neighborhoods { get;}
        //public virtual ICollection<StateCountry> StatesCountries { get; set; }
        //public virtual ICollection<CountryNeighorhood> CountriesNeighorhoods { get; set; }
    }

    //public class StateCountry {
    //    public int stateCountryId { get; set; }
    //    public int stateId { get; set; }
    //    public int countryId { get; set; }

    //    public virtual ICollection<State> States { get; set; }
    //    public virtual ICollection<Country> Countries { get; set; }
    //}

    public class Neighborhood {
        public Neighborhood() {
            this.Countries = new HashSet<Country>();
            this.ZipCodes = new HashSet<ZipCode>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int neightborhoodId { get; set; }
        public string neightborhoodName { get; set; }
        [Column("is_active")]
        public bool isActive { get; set; }
        [Column("created_date")]
        public DateTime createdDate { get; set; } = DateTime.Now;
        [Column("updated_date")]
        public DateTime updatedDate { get; set; } = DateTime.Now;

        public virtual ICollection <Country> Countries { get; set; }
        public virtual ICollection <ZipCode> ZipCodes { get; set;}
        //public virtual ICollection<CountryNeighorhood> CountriesNeighorhoods { get; set; }
        //public virtual ICollection<NeighborhoodZipCode> NeighborhoodsZipCodes { get; set; }
        

    }

    //public class CountryNeighorhood {
    //    public int countryNeighorhoodId { get; set; }
    //    [ForeignKey("Country")]
    //    [Column(Order = 1)]
    //    public int countryId { get; set; }
    //    [ForeignKey("Neighborhood")]
    //    [Column(Order = 2)]
    //    public int neightborhoodId { get; set; }

    //    public virtual ICollection<Country> Countries { get; set; }
    //    public virtual ICollection<Neighborhood> Neighborhoods { get; set; }
    //}

    public class ZipCode {

        public ZipCode() {
            this.Neighborhoods = new HashSet<Neighborhood>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int zipCodeId { get; set; }
        public string zipCode { get; set; }
        [Column("is_active")]
        public bool isActive { get; set; }
        [Column("created_date")]
        public DateTime createdDate { get; set; } = DateTime.Now;
        [Column("updated_date")]
        public DateTime updatedDate { get; set; } = DateTime.Now;

        public virtual ICollection<Neighborhood> Neighborhoods { get; set; }
        //public virtual ICollection<NeighborhoodZipCode> NeighborhoodsZipCodes { get; set; }
    }

    //public class NeighborhoodZipCode {
    //    public int neighborhoodZipCodeId { get; set; }
    //    [ForeignKey("Neighborhood")]
    //    [Column(Order = 1)]
    //    public int neightborhoodId { get; set; }
    //    [ForeignKey("ZipCode")]
    //    [Column(Order = 2)]
    //    public int zipCodeId { get; set; }

    //    public virtual ICollection<Neighborhood> Neighborhoods { get; set; }
    //    public virtual ICollection<ZipCode> ZipCodes { get; set; }    
    //}
}
