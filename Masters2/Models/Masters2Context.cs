using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Masters2.Models
{
    public partial class Masters2Context : DbContext
    {
        public Masters2Context()
        {
        }

        public Masters2Context(DbContextOptions<Masters2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<TbAnswer> TbAnswers { get; set; } = null!;
        public virtual DbSet<TbCategory> TbCategories { get; set; } = null!;
        public virtual DbSet<TbForm> TbForms { get; set; } = null!;
        public virtual DbSet<TbQuestion> TbQuestions { get; set; } = null!;
        public virtual DbSet<TbResult> TbResults { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-BBT3LB8\\SQLEXPRESS;Database=Masters2;user=Sa;password=123;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbAnswer>(entity =>
            {
                entity.HasKey(e => e.AnswerId)
                    .HasName("PK__TbAnswer__D4825004F1B63961");

                entity.Property(e => e.AnswerName).IsUnicode(false);
            });

            modelBuilder.Entity<TbCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK__TbCatego__19093A0B17C31D47");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbForm>(entity =>
            {
                entity.HasKey(e => e.FormId)
                    .HasName("PK__TbForms__FB05B7DD3D638485");

                entity.Property(e => e.FormDate).HasColumnType("date");

                entity.HasOne(d => d.Answer)
                    .WithMany(p => p.TbForms)
                    .HasForeignKey(d => d.AnswerId)
                    .HasConstraintName("FK__TbForms__AnswerI__412EB0B6");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TbForms)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__TbForms__Categor__3F466844");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.TbForms)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK__TbForms__Questio__403A8C7D");

                entity.HasOne(d => d.Result)
                    .WithMany(p => p.TbForms)
                    .HasForeignKey(d => d.ResultId)
                    .HasConstraintName("FK__TbForms__ResultI__4222D4EF");
            });

            modelBuilder.Entity<TbQuestion>(entity =>
            {
                entity.HasKey(e => e.QuestionId)
                    .HasName("PK__TbQuesti__0DC06FAC0E1E2092");

                entity.Property(e => e.QuestionName).IsUnicode(false);
            });

            modelBuilder.Entity<TbResult>(entity =>
            {
                entity.HasKey(e => e.ResultId)
                    .HasName("PK__TbResult__9769020804F2305D");

                entity.ToTable("TbResult");

                entity.Property(e => e.AnswerDate).HasColumnType("date");

                entity.Property(e => e.ResultName).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
