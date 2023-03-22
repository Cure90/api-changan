using back_end.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace back_end.Data {
    public class MotorNationDB: DbContext {

        public MotorNationDB(DbContextOptions<MotorNationDB> options) : base(options) { }

        public DbSet<Agency> Agencies => Set<Agency>();
        public DbSet<AgencyCar> AgencyCars => Set<AgencyCar>();
        public DbSet<Car> Cars => Set<Car>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<CatStatus> CatStatus => Set<CatStatus>();
        public DbSet<Contact> Contacts => Set<Contact>();
        public DbSet<Country> Countries => Set<Country>();
        public DbSet<EmailTemplate> EmailTemplates => Set<EmailTemplate>();
        public DbSet<EmailType> EmailTypes => Set<EmailType>();
        public DbSet<Inventory> Inventories => Set<Inventory>();
        public DbSet<Layaway> Layaway => Set<Layaway>();
        public DbSet<Model> Models => Set<Model>();
        public DbSet<Neighborhood> Neighborhoods => Set<Neighborhood>();
        public DbSet<Quotes> Quotes => Set<Quotes>();
        public DbSet<ServicesSchedule> ServicesSchedule => Set<ServicesSchedule>();
        public DbSet<SettingCar> settingCars => Set<SettingCar>();
        public DbSet<State> States => Set<State>();
        public DbSet<TestDriveSchedule> TestDriveSchedules  => Set<TestDriveSchedule>();
        public DbSet<User> Users => Set<User>();    
        public DbSet<UserInfo> UsersInfo => Set<UserInfo>();
        public DbSet<UserType> UserTypes => Set<UserType>();
        public DbSet<ZipCode> ZipCode => Set<ZipCode>();


        //protected override void OnModelCreating( ModelBuilder modelBuilder ) {
        //    modelBuilder.Entity<User>().HasKey(u => new {u.userId,u.userName });
        //}

    }
}
