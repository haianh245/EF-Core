using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QL_KhoaHoc_EF03.Migrations
{
    public partial class intitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "khoaHocs",
                columns: table => new
                {
                    KhoaHocID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKhoaHoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HocPhi = table.Column<int>(type: "int", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khoaHocs", x => x.KhoaHocID);
                });

            migrationBuilder.CreateTable(
                name: "hocViens",
                columns: table => new
                {
                    HocVienID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KhoaHocID = table.Column<int>(type: "int", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QueQuan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hocViens", x => x.HocVienID);
                    table.ForeignKey(
                        name: "FK_hocViens_khoaHocs_KhoaHocID",
                        column: x => x.KhoaHocID,
                        principalTable: "khoaHocs",
                        principalColumn: "KhoaHocID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ngayHocs",
                columns: table => new
                {
                    NgayHocID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KhoaHocID = table.Column<int>(type: "int", nullable: false),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ngayHocs", x => x.NgayHocID);
                    table.ForeignKey(
                        name: "FK_ngayHocs_khoaHocs_KhoaHocID",
                        column: x => x.KhoaHocID,
                        principalTable: "khoaHocs",
                        principalColumn: "KhoaHocID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_hocViens_KhoaHocID",
                table: "hocViens",
                column: "KhoaHocID");

            migrationBuilder.CreateIndex(
                name: "IX_ngayHocs_KhoaHocID",
                table: "ngayHocs",
                column: "KhoaHocID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "hocViens");

            migrationBuilder.DropTable(
                name: "ngayHocs");

            migrationBuilder.DropTable(
                name: "khoaHocs");
        }
    }
}
