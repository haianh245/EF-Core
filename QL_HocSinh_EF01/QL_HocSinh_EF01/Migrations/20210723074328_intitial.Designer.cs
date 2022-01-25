﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QL_HocSinh_EF01;

namespace QL_HocSinh_EF01.Migrations
{
    [DbContext(typeof(QLHocSinhDbContext))]
    [Migration("20210723074328_intitial")]
    partial class intitial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QL_HocSinh_EF01.Entities.HocSinh", b =>
                {
                    b.Property<int>("HocSinhID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LopID")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("QueQuan")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HocSinhID");

                    b.HasIndex("LopID");

                    b.ToTable("hocSinhs");
                });

            modelBuilder.Entity("QL_HocSinh_EF01.Entities.Lop", b =>
                {
                    b.Property<int>("LopID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SiSo")
                        .HasColumnType("int");

                    b.Property<string>("TenLop")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LopID");

                    b.ToTable("lops");
                });

            modelBuilder.Entity("QL_HocSinh_EF01.Entities.HocSinh", b =>
                {
                    b.HasOne("QL_HocSinh_EF01.Entities.Lop", "Lop")
                        .WithMany("HocSinhs")
                        .HasForeignKey("LopID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lop");
                });

            modelBuilder.Entity("QL_HocSinh_EF01.Entities.Lop", b =>
                {
                    b.Navigation("HocSinhs");
                });
#pragma warning restore 612, 618
        }
    }
}
