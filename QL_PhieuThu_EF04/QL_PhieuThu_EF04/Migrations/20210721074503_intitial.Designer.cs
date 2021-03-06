// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QL_PhieuThu_EF04;

namespace QL_PhieuThu_EF04.Migrations
{
    [DbContext(typeof(QLPhieuThuDbContext))]
    [Migration("20210721074503_intitial")]
    partial class intitial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QL_PhieuThu_EF04.Entities.ChiTietPhieuThu", b =>
                {
                    b.Property<int>("ChitietphieuthuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NguyenlieuID")
                        .HasColumnType("int");

                    b.Property<int>("PhieuthuID")
                        .HasColumnType("int");

                    b.Property<int>("Soluongban")
                        .HasColumnType("int");

                    b.HasKey("ChitietphieuthuID");

                    b.HasIndex("NguyenlieuID");

                    b.HasIndex("PhieuthuID");

                    b.ToTable("chiTietPhieuThus");
                });

            modelBuilder.Entity("QL_PhieuThu_EF04.Entities.LoaiNguyenLieu", b =>
                {
                    b.Property<int>("LoainguyenlieuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Mota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tenloai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LoainguyenlieuID");

                    b.ToTable("loaiNguyenLieus");
                });

            modelBuilder.Entity("QL_PhieuThu_EF04.Entities.NguyenLieu", b =>
                {
                    b.Property<int>("NguyenlieuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Donvitinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Giaban")
                        .HasColumnType("bigint");

                    b.Property<int>("LoainguyenlieuID")
                        .HasColumnType("int");

                    b.Property<int>("Soluongkho")
                        .HasColumnType("int");

                    b.Property<string>("Tennguyenlieu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NguyenlieuID");

                    b.HasIndex("LoainguyenlieuID");

                    b.ToTable("nguyenLieus");
                });

            modelBuilder.Entity("QL_PhieuThu_EF04.Entities.PhieuThu", b =>
                {
                    b.Property<int>("PhieuthuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ghichu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Ngaylap")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nhanvienlap")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Thanhtien")
                        .HasColumnType("bigint");

                    b.HasKey("PhieuthuID");

                    b.ToTable("phieuThus");
                });

            modelBuilder.Entity("QL_PhieuThu_EF04.Entities.ChiTietPhieuThu", b =>
                {
                    b.HasOne("QL_PhieuThu_EF04.Entities.NguyenLieu", "NguyenLieu")
                        .WithMany("ChiTietPhieuThus")
                        .HasForeignKey("NguyenlieuID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QL_PhieuThu_EF04.Entities.PhieuThu", "PhieuThu")
                        .WithMany("ChiTietPhieuThus")
                        .HasForeignKey("PhieuthuID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NguyenLieu");

                    b.Navigation("PhieuThu");
                });

            modelBuilder.Entity("QL_PhieuThu_EF04.Entities.NguyenLieu", b =>
                {
                    b.HasOne("QL_PhieuThu_EF04.Entities.LoaiNguyenLieu", "LoaiNguyenLieu")
                        .WithMany("NguyenLieus")
                        .HasForeignKey("LoainguyenlieuID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoaiNguyenLieu");
                });

            modelBuilder.Entity("QL_PhieuThu_EF04.Entities.LoaiNguyenLieu", b =>
                {
                    b.Navigation("NguyenLieus");
                });

            modelBuilder.Entity("QL_PhieuThu_EF04.Entities.NguyenLieu", b =>
                {
                    b.Navigation("ChiTietPhieuThus");
                });

            modelBuilder.Entity("QL_PhieuThu_EF04.Entities.PhieuThu", b =>
                {
                    b.Navigation("ChiTietPhieuThus");
                });
#pragma warning restore 612, 618
        }
    }
}
