﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QL_MonAn_EF_05;

namespace QL_MonAn_EF_05.Migrations
{
    [DbContext(typeof(QLMonAnDbContext))]
    partial class QLMonAnDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QL_MonAn_EF_05.Entities.CongThuc", b =>
                {
                    b.Property<int>("CongThucID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DonViTinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MonAnID")
                        .HasColumnType("int");

                    b.Property<int>("NguyenLieuID")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("CongThucID");

                    b.HasIndex("MonAnID");

                    b.HasIndex("NguyenLieuID");

                    b.ToTable("congThucs");
                });

            modelBuilder.Entity("QL_MonAn_EF_05.Entities.LoaiMonAn", b =>
                {
                    b.Property<int>("LoaiMonAnID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenLoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LoaiMonAnID");

                    b.ToTable("loaiMonAns");
                });

            modelBuilder.Entity("QL_MonAn_EF_05.Entities.MonAn", b =>
                {
                    b.Property<int>("MonAnID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CachLam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GiaBan")
                        .HasColumnType("int");

                    b.Property<string>("GioiThieu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LoaiMonAnID")
                        .HasColumnType("int");

                    b.Property<string>("TenMon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MonAnID");

                    b.HasIndex("LoaiMonAnID");

                    b.ToTable("monAns");
                });

            modelBuilder.Entity("QL_MonAn_EF_05.Entities.NguyenLieu", b =>
                {
                    b.Property<int>("NguyenLieuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNguyenLieu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NguyenLieuID");

                    b.ToTable("nguyenLieus");
                });

            modelBuilder.Entity("QL_MonAn_EF_05.Entities.CongThuc", b =>
                {
                    b.HasOne("QL_MonAn_EF_05.Entities.MonAn", "MonAn")
                        .WithMany("CongThucs")
                        .HasForeignKey("MonAnID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QL_MonAn_EF_05.Entities.NguyenLieu", "NguyenLieu")
                        .WithMany()
                        .HasForeignKey("NguyenLieuID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MonAn");

                    b.Navigation("NguyenLieu");
                });

            modelBuilder.Entity("QL_MonAn_EF_05.Entities.MonAn", b =>
                {
                    b.HasOne("QL_MonAn_EF_05.Entities.LoaiMonAn", "LoaiMonAn")
                        .WithMany("MonAns")
                        .HasForeignKey("LoaiMonAnID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoaiMonAn");
                });

            modelBuilder.Entity("QL_MonAn_EF_05.Entities.LoaiMonAn", b =>
                {
                    b.Navigation("MonAns");
                });

            modelBuilder.Entity("QL_MonAn_EF_05.Entities.MonAn", b =>
                {
                    b.Navigation("CongThucs");
                });
#pragma warning restore 612, 618
        }
    }
}
