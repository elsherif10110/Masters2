using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Masters2.Models
{
    public partial class FormManagementContext : DbContext
    {
        public FormManagementContext()
        {
        }

        public FormManagementContext(DbContextOptions<FormManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Answer> Answers { get; set; } = null!;
        public virtual DbSet<AnswerType> AnswerTypes { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Form> Forms { get; set; } = null!;
        public virtual DbSet<FormDetail> FormDetails { get; set; } = null!;
        public virtual DbSet<Question> Questions { get; set; } = null!;
        public virtual DbSet<Result> Results { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-BBT3LB8\\SQLEXPRESS;Database=FormManagement;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answer>(entity =>
            {
                entity.HasOne(d => d.AnswerType)
                    .WithMany(p => p.Answers)
                    .HasForeignKey(d => d.AnswerTypeId)
                    .HasConstraintName("FK__Answers__AnswerT__1CBC4616");
            });

            modelBuilder.Entity<AnswerType>(entity =>
            {
                entity.Property(e => e.AnswerTypeName).HasMaxLength(255);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryName).HasMaxLength(255);
            });

            modelBuilder.Entity<Form>(entity =>
            {
                entity.Property(e => e.FormDate).HasColumnType("date");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Forms)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Forms__CategoryI__1F98B2C1");
            });

            modelBuilder.Entity<FormDetail>(entity =>
            {
                entity.HasNoKey();

                entity.HasOne(d => d.Answer)
                    .WithMany()
                    .HasForeignKey(d => d.AnswerId)
                    .HasConstraintName("FK__FormDetai__Answe__2739D489");

                entity.HasOne(d => d.AnswerType)
                    .WithMany()
                    .HasForeignKey(d => d.AnswerTypeId)
                    .HasConstraintName("FK__FormDetai__Answe__282DF8C2");

                entity.HasOne(d => d.Form)
                    .WithMany()
                    .HasForeignKey(d => d.FormId)
                    .HasConstraintName("FK__FormDetai__FormI__2645B050");

                entity.HasOne(d => d.Question)
                    .WithMany()
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK__FormDetai__Quest__29221CFB");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Questions__Categ__17F790F9");
            });

            modelBuilder.Entity<Result>(entity =>
            {
                entity.Property(e => e.ResultDate).HasColumnType("date");

                entity.HasOne(d => d.Answer)
                    .WithMany(p => p.Results)
                    .HasForeignKey(d => d.AnswerId)
                    .HasConstraintName("FK__Results__AnswerI__245D67DE");

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.Results)
                    .HasForeignKey(d => d.FormId)
                    .HasConstraintName("FK__Results__FormId__22751F6C");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Results)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK__Results__Questio__236943A5");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
