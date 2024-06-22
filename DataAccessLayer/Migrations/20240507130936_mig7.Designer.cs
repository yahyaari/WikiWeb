﻿// <auto-generated />
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240507130936_mig7")]
    partial class mig7
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityLayer.Concrete.AboutUs", b =>
                {
                    b.Property<int>("AboutUsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AboutUsId"));

                    b.Property<string>("AboutUsContent")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AboutUsId");

                    b.ToTable("AboutUs");

                    b.HasData(
                        new
                        {
                            AboutUsId = 1,
                            AboutUsContent = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                        });
                });

            modelBuilder.Entity("EntityLayer.Concrete.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"));

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CategoryStatus")
                        .HasColumnType("bit");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 100,
                            CategoryDescription = "İçerik",
                            CategoryName = "Paragraph",
                            CategoryStatus = true
                        },
                        new
                        {
                            CategoryID = 101,
                            CategoryDescription = "İçerik",
                            CategoryName = "Paragraph",
                            CategoryStatus = true
                        });
                });

            modelBuilder.Entity("EntityLayer.Concrete.Lecture", b =>
                {
                    b.Property<int>("LectureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LectureId"));

                    b.Property<string>("LectureContent")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LectureId");

                    b.ToTable("Lectures");

                    b.HasData(
                        new
                        {
                            LectureId = 1,
                            LectureContent = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                        });
                });

            modelBuilder.Entity("EntityLayer.Concrete.Paragraph", b =>
                {
                    b.Property<int>("ParagraphID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ParagraphID"));

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("ParagraphContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ParagraphStatus")
                        .HasColumnType("bit");

                    b.Property<string>("ParagraphTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ParagraphID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Paragraphs");

                    b.HasData(
                        new
                        {
                            ParagraphID = 100,
                            CategoryID = 100,
                            ParagraphContent = "blablablabla",
                            ParagraphStatus = true,
                            ParagraphTitle = "Homomorfik Wiki"
                        },
                        new
                        {
                            ParagraphID = 101,
                            CategoryID = 101,
                            ParagraphContent = "Lorem Ipsum is simply dummy text of the printing and typesetting industry",
                            ParagraphStatus = true,
                            ParagraphTitle = "homo"
                        });
                });

            modelBuilder.Entity("EntityLayer.Concrete.Paragraph", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Category", "Category")
                        .WithMany("Paragraphs")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Category", b =>
                {
                    b.Navigation("Paragraphs");
                });
#pragma warning restore 612, 618
        }
    }
}
