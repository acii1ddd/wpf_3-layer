using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.EF
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated(); // при миграциях не используется
        }

        // таблицы для сущностей
        public DbSet<Passenger> Passengers { get; set; }

        public DbSet<Ticket> Tickets { get; set; }

        public DbSet<Train> Trains { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Passenger>().HasData(
        //        new Passenger { Id = 1, FirstName = "Коля", SecondName = "Петров", Phone = "+375223489993", PassportData = "HB1234224" }
        //    );
        //}
    }
}
