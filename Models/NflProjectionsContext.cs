using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace reactApp.Models
{
    public partial class NflProjectionsContext : DbContext
    {
        public NflProjectionsContext()
        {
        }

        public NflProjectionsContext(DbContextOptions<NflProjectionsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<NflProj> NflProj { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseMySql("Server=127.0.0.1;Database=nflProjections;UID=testUser;pwd=a12345;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NflProj>(entity =>
            {
                entity.HasKey(e => e.Rnk);

                entity.ToTable("nflProj");

                entity.Property(e => e.Rnk).HasColumnType("int(11)");

                entity.Property(e => e.Bye).HasColumnType("int(11)");

                entity.Property(e => e.Dk).HasColumnName("dk");

                entity.Property(e => e.Game).HasColumnType("text");

                entity.Property(e => e.Int).HasColumnType("int(11)");

                entity.Property(e => e.Name).HasColumnType("text");

                entity.Property(e => e.Pos).HasColumnType("text");

                entity.Property(e => e.RecTds).HasColumnName("RecTDs");

                entity.Property(e => e.RuTd).HasColumnName("RuTD");

                entity.Property(e => e.Td)
                    .HasColumnName("TD")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Team).HasColumnType("text");

                entity.Property(e => e.Yds).HasColumnType("int(11)");
            });
        }
    }
}
