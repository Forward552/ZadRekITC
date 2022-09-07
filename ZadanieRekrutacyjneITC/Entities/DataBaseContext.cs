using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ZadanieRekrutacyjneITC.Entities
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Document> Documents { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Log> Logs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Properties.Settings.Default.LocalDb);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Document>().Property(e => e.ClientNumber).IsRequired();
            modelBuilder.Entity<Document>(eb =>
            {
                eb.Property(d => d.ClientNumber).IsRequired();
                eb.Property(d => d.PriceN).HasPrecision(10, 2);
                eb.Property(d => d.PriceB).HasPrecision(11, 2);
                eb.Property(d => d.Name).HasColumnType("varchar(100)");
                eb.Property(d => d.Title).HasMaxLength(100);
                eb.HasMany(d => d.Items)
                .WithOne(i =>i.Document)
                .HasForeignKey(i =>i.DocumentId);
            });


     

            modelBuilder.Entity<Item>(eb =>
            {
                eb.Property(i => i.Count).IsRequired();
                eb.Property(i => i.Name).IsRequired();
                eb.Property(i => i.PriceB).HasPrecision(6,2);
                eb.Property(i => i.PriceN).HasPrecision(5,2);
                eb.Property(i => i.Name).HasMaxLength(50);
                eb.Property(i => i.Count).HasPrecision(5,2);
            });
           
            modelBuilder.Entity<Log>(eb =>
            {
                eb.Property(l => l.Date).HasDefaultValueSql("getutcdate()");
            });




        }

    }
}
