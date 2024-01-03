using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Masters2.YourOutputDirectory
{
    public partial class FormsContext : IdentityDbContext<IdentityUser>
    {
        public FormsContext()
        {
        }

        public FormsContext(DbContextOptions<FormsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbCategory> TbCategories { get; set; } = null!;
        public virtual DbSet<TbForm> TbForms { get; set; } = null!;
        public virtual DbSet<TbResult> TbResults { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-BBT3LB8\\SQLEXPRESS;Database=Forms;user=Sa;password=123;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Arabic_CI_AI");

            modelBuilder.Entity<TbCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.Property(e => e.CategoryName).HasMaxLength(50);
            });

            modelBuilder.Entity<TbForm>(entity =>
            {
                entity.HasKey(e => e.FormId);

                entity.Property(e => e.CreationDate).HasColumnType("date");

                entity.Property(e => e.FormTitle).HasMaxLength(30);
            });

            modelBuilder.Entity<TbResult>(entity =>
            {
                entity.HasKey(e => e.ResultId);

                entity.Property(e => e.AnswerDate).HasColumnType("date");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
