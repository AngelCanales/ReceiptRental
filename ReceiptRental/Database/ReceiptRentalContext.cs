namespace ReceiptRental.Database
{
    using System.IO;
    using Microsoft.EntityFrameworkCore;
    using ReceiptRental.Database.Models;
    using Xamarin.Essentials;

    public class ReceiptRentalContext : DbContext
    {
        public ReceiptRentalContext()
        {
        }

        public DbSet<Alkylino> Alkylino { get; set; }

        public DbSet<PaymentTypes> PaymentTypes { get; set; }

        public DbSet<Owner> Owner { get; set; }

        public DbSet<Apartments> Apartments { get; set; }

        public DbSet<Receipt> Receipt { get; set; }

        public DbSet<Templates> Templates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "ReceiptRental.db3");

            optionsBuilder
                .UseSqlite($"Filename={dbPath}");
            //  .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
    }
}
