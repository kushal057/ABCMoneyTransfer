using ABC.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace ABC.Infrastructure.Identity.Data;

public class AppDBContext : IdentityDbContext<IdentityUser>
{
    public DbSet<MoneyTransfer> MoneyTransfer { get; set; }
    public DbSet<PaymentDetail> PaymentDetail { get; set; }
    public DbSet<Sender> Sender { get; set; }
    public DbSet<Receiver> Receiver { get; set; }
    public DbSet<Rate> Rate { get; set; }
    public DbSet<Currency> Currency { get; set; }

    public AppDBContext(DbContextOptions<AppDBContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MoneyTransfer>()
           .HasOne(mt => mt.Sender)
           .WithMany()
           .HasForeignKey(mt => mt.SenderId)
           .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<MoneyTransfer>()
            .HasOne(mt => mt.Receiver)
            .WithMany()
            .HasForeignKey(mt => mt.ReceiverId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<MoneyTransfer>()
            .HasOne(mt => mt.PaymentDetail)
            .WithMany()
            .HasForeignKey(mt => mt.PaymentDetailId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Rate>()
            .HasMany(mt => mt.Currencies)
            .WithOne(c => c.Rate)
            .HasForeignKey(mt => mt.RateId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Sender>()
            .HasOne(mt => mt.PersonalDetails)
            .WithMany()
            .HasForeignKey(mt => mt.PersonalDetailId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Receiver>()
            .HasOne(mt => mt.PersonalDetails)
            .WithMany()
            .HasForeignKey(mt => mt.PersonalDetailId)
            .OnDelete(DeleteBehavior.Cascade);

        base.OnModelCreating(modelBuilder);
    }
}
