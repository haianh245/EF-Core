using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QL_PhieuThu_EF04.Migrations
{
    public partial class intitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "loaiNguyenLieus",
                columns: table => new
                {
                    LoainguyenlieuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tenloai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loaiNguyenLieus", x => x.LoainguyenlieuID);
                });

            migrationBuilder.CreateTable(
                name: "phieuThus",
                columns: table => new
                {
                    PhieuthuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ngaylap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nhanvienlap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ghichu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Thanhtien = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phieuThus", x => x.PhieuthuID);
                });

            migrationBuilder.CreateTable(
                name: "nguyenLieus",
                columns: table => new
                {
                    NguyenlieuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoainguyenlieuID = table.Column<int>(type: "int", nullable: false),
                    Tennguyenlieu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Giaban = table.Column<long>(type: "bigint", nullable: false),
                    Donvitinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soluongkho = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nguyenLieus", x => x.NguyenlieuID);
                    table.ForeignKey(
                        name: "FK_nguyenLieus_loaiNguyenLieus_LoainguyenlieuID",
                        column: x => x.LoainguyenlieuID,
                        principalTable: "loaiNguyenLieus",
                        principalColumn: "LoainguyenlieuID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "chiTietPhieuThus",
                columns: table => new
                {
                    ChitietphieuthuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NguyenlieuID = table.Column<int>(type: "int", nullable: false),
                    PhieuthuID = table.Column<int>(type: "int", nullable: false),
                    Soluongban = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chiTietPhieuThus", x => x.ChitietphieuthuID);
                    table.ForeignKey(
                        name: "FK_chiTietPhieuThus_nguyenLieus_NguyenlieuID",
                        column: x => x.NguyenlieuID,
                        principalTable: "nguyenLieus",
                        principalColumn: "NguyenlieuID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_chiTietPhieuThus_phieuThus_PhieuthuID",
                        column: x => x.PhieuthuID,
                        principalTable: "phieuThus",
                        principalColumn: "PhieuthuID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_chiTietPhieuThus_NguyenlieuID",
                table: "chiTietPhieuThus",
                column: "NguyenlieuID");

            migrationBuilder.CreateIndex(
                name: "IX_chiTietPhieuThus_PhieuthuID",
                table: "chiTietPhieuThus",
                column: "PhieuthuID");

            migrationBuilder.CreateIndex(
                name: "IX_nguyenLieus_LoainguyenlieuID",
                table: "nguyenLieus",
                column: "LoainguyenlieuID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "chiTietPhieuThus");

            migrationBuilder.DropTable(
                name: "nguyenLieus");

            migrationBuilder.DropTable(
                name: "phieuThus");

            migrationBuilder.DropTable(
                name: "loaiNguyenLieus");
        }
    }
}
