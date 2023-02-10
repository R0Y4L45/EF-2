﻿// <auto-generated />
using System;
using EntityFrameWork_Hw2.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityFrameWorkHw2.Migrations
{
    [DbContext(typeof(ContexApp))]
    [Migration("20230210203704_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityFrameWork_Hw2.Models.Authors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authorss");
                });

            modelBuilder.Entity("EntityFrameWork_Hw2.Models.Books", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Commennt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Author")
                        .HasColumnType("int");

                    b.Property<int>("Id_Category")
                        .HasColumnType("int");

                    b.Property<int>("Id_Press")
                        .HasColumnType("int");

                    b.Property<int>("Id_Themes")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pages")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("YearPress")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Id_Author");

                    b.HasIndex("Id_Category");

                    b.HasIndex("Id_Press");

                    b.HasIndex("Id_Themes");

                    b.ToTable("Bookss");
                });

            modelBuilder.Entity("EntityFrameWork_Hw2.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categorys");
                });

            modelBuilder.Entity("EntityFrameWork_Hw2.Models.Departments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departmentss");
                });

            modelBuilder.Entity("EntityFrameWork_Hw2.Models.Faculties", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Facultiess");
                });

            modelBuilder.Entity("EntityFrameWork_Hw2.Models.Groups", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Id_Facultity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id_Facultity");

                    b.ToTable("Groupss");
                });

            modelBuilder.Entity("EntityFrameWork_Hw2.Models.Libs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Libss");
                });

            modelBuilder.Entity("EntityFrameWork_Hw2.Models.Press", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Presss");
                });

            modelBuilder.Entity("EntityFrameWork_Hw2.Models.S_Cards", b =>
                {
                    b.Property<DateTime>("DateIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOut")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Books")
                        .HasColumnType("int");

                    b.Property<int>("Id_Lib")
                        .HasColumnType("int");

                    b.Property<int>("Id_Student")
                        .HasColumnType("int");

                    b.HasIndex("Id_Books");

                    b.HasIndex("Id_Lib");

                    b.HasIndex("Id_Student");

                    b.ToTable("S_Cardss");
                });

            modelBuilder.Entity("EntityFrameWork_Hw2.Models.Students", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Group")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Term")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_Group");

                    b.ToTable("Studentss");
                });

            modelBuilder.Entity("EntityFrameWork_Hw2.Models.T_Cards", b =>
                {
                    b.Property<DateTime>("DateIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOut")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Books")
                        .HasColumnType("int");

                    b.Property<int>("Id_Lib")
                        .HasColumnType("int");

                    b.Property<int>("Id_Teacher")
                        .HasColumnType("int");

                    b.HasIndex("Id_Books");

                    b.HasIndex("Id_Lib");

                    b.HasIndex("Id_Teacher");

                    b.ToTable("T_Cardss");
                });

            modelBuilder.Entity("EntityFrameWork_Hw2.Models.Teachers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Dep")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id_Dep");

                    b.ToTable("Teacherss");
                });

            modelBuilder.Entity("EntityFrameWork_Hw2.Models.Themes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Themess");
                });

            modelBuilder.Entity("EntityFrameWork_Hw2.Models.Books", b =>
                {
                    b.HasOne("EntityFrameWork_Hw2.Models.Authors", null)
                        .WithMany()
                        .HasForeignKey("Id_Author")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFrameWork_Hw2.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("Id_Category")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFrameWork_Hw2.Models.Press", null)
                        .WithMany()
                        .HasForeignKey("Id_Press")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFrameWork_Hw2.Models.Themes", null)
                        .WithMany()
                        .HasForeignKey("Id_Themes")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EntityFrameWork_Hw2.Models.Groups", b =>
                {
                    b.HasOne("EntityFrameWork_Hw2.Models.Faculties", null)
                        .WithMany()
                        .HasForeignKey("Id_Facultity")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EntityFrameWork_Hw2.Models.S_Cards", b =>
                {
                    b.HasOne("EntityFrameWork_Hw2.Models.Books", null)
                        .WithMany()
                        .HasForeignKey("Id_Books")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFrameWork_Hw2.Models.Libs", null)
                        .WithMany()
                        .HasForeignKey("Id_Lib")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFrameWork_Hw2.Models.Students", null)
                        .WithMany()
                        .HasForeignKey("Id_Student")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EntityFrameWork_Hw2.Models.Students", b =>
                {
                    b.HasOne("EntityFrameWork_Hw2.Models.Groups", null)
                        .WithMany()
                        .HasForeignKey("Id_Group")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EntityFrameWork_Hw2.Models.T_Cards", b =>
                {
                    b.HasOne("EntityFrameWork_Hw2.Models.Books", null)
                        .WithMany()
                        .HasForeignKey("Id_Books")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFrameWork_Hw2.Models.Libs", null)
                        .WithMany()
                        .HasForeignKey("Id_Lib")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFrameWork_Hw2.Models.Teachers", null)
                        .WithMany()
                        .HasForeignKey("Id_Teacher")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EntityFrameWork_Hw2.Models.Teachers", b =>
                {
                    b.HasOne("EntityFrameWork_Hw2.Models.Departments", null)
                        .WithMany()
                        .HasForeignKey("Id_Dep")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
