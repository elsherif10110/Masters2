﻿// <auto-generated />
using System;
using Masters2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Masters2.Migrations
{
    [DbContext(typeof(FormManagementContext))]
    [Migration("20231217225534_Migration01")]
    partial class Migration01
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Masters2.Models.Answer", b =>
                {
                    b.Property<int>("AnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnswerId"), 1L, 1);

                    b.Property<string>("AnswerText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AnswerTypeId")
                        .HasColumnType("int");

                    b.HasKey("AnswerId");

                    b.HasIndex("AnswerTypeId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("Masters2.Models.AnswerType", b =>
                {
                    b.Property<int>("AnswerTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnswerTypeId"), 1L, 1);

                    b.Property<string>("AnswerTypeName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AnswerTypeId");

                    b.ToTable("AnswerTypes");
                });

            modelBuilder.Entity("Masters2.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Masters2.Models.Form", b =>
                {
                    b.Property<int>("FormId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FormId"), 1L, 1);

                    b.Property<int?>("AdminId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FormDate")
                        .HasColumnType("date");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("FormId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Forms");
                });

            modelBuilder.Entity("Masters2.Models.FormDetail", b =>
                {
                    b.Property<int?>("AnswerId")
                        .HasColumnType("int");

                    b.Property<int?>("AnswerTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("FormId")
                        .HasColumnType("int");

                    b.Property<int?>("QuestionId")
                        .HasColumnType("int");

                    b.HasIndex("AnswerId");

                    b.HasIndex("AnswerTypeId");

                    b.HasIndex("FormId");

                    b.HasIndex("QuestionId");

                    b.ToTable("FormDetails");
                });

            modelBuilder.Entity("Masters2.Models.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuestionId"), 1L, 1);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("QuestionText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuestionId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Masters2.Models.Result", b =>
                {
                    b.Property<int>("ResultId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResultId"), 1L, 1);

                    b.Property<int?>("AnswerId")
                        .HasColumnType("int");

                    b.Property<int?>("FormId")
                        .HasColumnType("int");

                    b.Property<int?>("QuestionId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ResultDate")
                        .HasColumnType("date");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ResultId");

                    b.HasIndex("AnswerId");

                    b.HasIndex("FormId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("Masters2.Models.Answer", b =>
                {
                    b.HasOne("Masters2.Models.AnswerType", "AnswerType")
                        .WithMany("Answers")
                        .HasForeignKey("AnswerTypeId")
                        .HasConstraintName("FK__Answers__AnswerT__1CBC4616");

                    b.Navigation("AnswerType");
                });

            modelBuilder.Entity("Masters2.Models.Form", b =>
                {
                    b.HasOne("Masters2.Models.Category", "Category")
                        .WithMany("Forms")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK__Forms__CategoryI__1F98B2C1");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Masters2.Models.FormDetail", b =>
                {
                    b.HasOne("Masters2.Models.Answer", "Answer")
                        .WithMany()
                        .HasForeignKey("AnswerId")
                        .HasConstraintName("FK__FormDetai__Answe__2739D489");

                    b.HasOne("Masters2.Models.AnswerType", "AnswerType")
                        .WithMany()
                        .HasForeignKey("AnswerTypeId")
                        .HasConstraintName("FK__FormDetai__Answe__282DF8C2");

                    b.HasOne("Masters2.Models.Form", "Form")
                        .WithMany()
                        .HasForeignKey("FormId")
                        .HasConstraintName("FK__FormDetai__FormI__2645B050");

                    b.HasOne("Masters2.Models.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .HasConstraintName("FK__FormDetai__Quest__29221CFB");

                    b.Navigation("Answer");

                    b.Navigation("AnswerType");

                    b.Navigation("Form");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Masters2.Models.Question", b =>
                {
                    b.HasOne("Masters2.Models.Category", "Category")
                        .WithMany("Questions")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK__Questions__Categ__17F790F9");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Masters2.Models.Result", b =>
                {
                    b.HasOne("Masters2.Models.Answer", "Answer")
                        .WithMany("Results")
                        .HasForeignKey("AnswerId")
                        .HasConstraintName("FK__Results__AnswerI__245D67DE");

                    b.HasOne("Masters2.Models.Form", "Form")
                        .WithMany("Results")
                        .HasForeignKey("FormId")
                        .HasConstraintName("FK__Results__FormId__22751F6C");

                    b.HasOne("Masters2.Models.Question", "Question")
                        .WithMany("Results")
                        .HasForeignKey("QuestionId")
                        .HasConstraintName("FK__Results__Questio__236943A5");

                    b.Navigation("Answer");

                    b.Navigation("Form");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Masters2.Models.Answer", b =>
                {
                    b.Navigation("Results");
                });

            modelBuilder.Entity("Masters2.Models.AnswerType", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("Masters2.Models.Category", b =>
                {
                    b.Navigation("Forms");

                    b.Navigation("Questions");
                });

            modelBuilder.Entity("Masters2.Models.Form", b =>
                {
                    b.Navigation("Results");
                });

            modelBuilder.Entity("Masters2.Models.Question", b =>
                {
                    b.Navigation("Results");
                });
#pragma warning restore 612, 618
        }
    }
}
