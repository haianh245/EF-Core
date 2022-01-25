﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QLNhanVienEF;

namespace QLNhanVienEF.Migrations
{
    [DbContext(typeof(QLNhanVienDbContext))]
    [Migration("20210324081241_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("QLNhanVienEF.Entitis.DuAn", b =>
                {
                    b.Property<int>("DuAnId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenDuAn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DuAnId");

                    b.ToTable("duAns");
                });

            modelBuilder.Entity("QLNhanVienEF.Entitis.NhanVien", b =>
                {
                    b.Property<int>("NhanVienId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HeSoLuong")
                        .HasColumnType("int");

                    b.Property<string>("HoTen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sdt")
                        .HasColumnType("int");

                    b.HasKey("NhanVienId");

                    b.ToTable("nhanViens");
                });

            modelBuilder.Entity("QLNhanVienEF.Entitis.PhanCong", b =>
                {
                    b.Property<int>("PhanCongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("DuAnId")
                        .HasColumnType("int");

                    b.Property<int>("NhanVienId")
                        .HasColumnType("int");

                    b.Property<int>("SoGioLam")
                        .HasColumnType("int");

                    b.HasKey("PhanCongId");

                    b.HasIndex("DuAnId");

                    b.HasIndex("NhanVienId");

                    b.ToTable("phanCongs");
                });

            modelBuilder.Entity("QLNhanVienEF.Entitis.PhanCong", b =>
                {
                    b.HasOne("QLNhanVienEF.Entitis.DuAn", "DuAn")
                        .WithMany("PhanCongs")
                        .HasForeignKey("DuAnId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QLNhanVienEF.Entitis.NhanVien", "NhanVien")
                        .WithMany("PhanCongs")
                        .HasForeignKey("NhanVienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DuAn");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("QLNhanVienEF.Entitis.DuAn", b =>
                {
                    b.Navigation("PhanCongs");
                });

            modelBuilder.Entity("QLNhanVienEF.Entitis.NhanVien", b =>
                {
                    b.Navigation("PhanCongs");
                });
#pragma warning restore 612, 618
        }
    }
}
