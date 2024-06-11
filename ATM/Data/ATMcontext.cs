using ATM.Models;
using ATMApp.Models;
// Data/ATMContext.cs
using Microsoft.EntityFrameworkCore;

namespace ATM.Data;

public class ATMContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Card> Cards { get; set; }
    public DbSet<Transaction> Transaction { get; set; }
    public DbSet<Account> Accounts { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=82.66.203.90:5432;Database=atmappdb;Username=atmadmin;Password=SECRET");
    }

    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(new User { Id = 1, Name = "John Doe" });
        modelBuilder.Entity<Account>().HasData(new Account { Id = 1, AccountNumber = "1234567890", Balance = 1000.0m, UserId = 1 });
        modelBuilder.Entity<Card>().HasData(new Card { Id = 1, CardNumber = "1111222233334444", PinCode = "1234", UserId = 1, AccountId = 1 });

        // Configurer les relations
        modelBuilder.Entity<Card>()
            .HasOne(c => c.User)
            .WithMany(u => u.Cards)
            .HasForeignKey(c => c.UserId);

        modelBuilder.Entity<Card>()
            .HasOne(c => c.Account)
            .WithMany(a => a.Cards)
            .HasForeignKey(c => c.AccountId);
    }




}
