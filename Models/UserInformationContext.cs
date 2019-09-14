using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace reactApp.Models
{
    public partial class UserInformationContext : DbContext
    {
        public UserInformationContext()
        {
        }

        public UserInformationContext(DbContextOptions<UserInformationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Contact> Contact { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseMySql("Server=127.0.0.1;Database=userInformation;UID=testUser;pwd=a12345;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("contact");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(120)");
            });
        }
    }
}
