using Microsoft.EntityFrameworkCore.Migrations;

namespace EFC_02.Migrations
{
    public partial class intitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "loaiMonAns",
                columns: table => new
                {
                    LoaiMonAnID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loaiMonAns", x => x.LoaiMonAnID);
                });

            migrationBuilder.CreateTable(
                name: "nguyenLieus",
                columns: table => new
                {
                    NguyenLieuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNguyenLieu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nguyenLieus", x => x.NguyenLieuID);
                });

            migrationBuilder.CreateTable(
                name: "monAns",
                columns: table => new
                {
                    MonAnID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaiMonAnID = table.Column<int>(type: "int", nullable: false),
                    TenMon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_monAns", x => x.MonAnID);
                    table.ForeignKey(
                        name: "FK_monAns_loaiMonAns_LoaiMonAnID",
                        column: x => x.LoaiMonAnID,
                        principalTable: "loaiMonAns",
                        principalColumn: "LoaiMonAnID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "congThucs",
                columns: table => new
                {
                    CongThucID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NguyenLieuID = table.Column<int>(type: "int", nullable: false),
                    MonAnID = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonViTinh = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_congThucs", x => x.CongThucID);
                    table.ForeignKey(
                        name: "FK_congThucs_monAns_MonAnID",
                        column: x => x.MonAnID,
                        principalTable: "monAns",
                        principalColumn: "MonAnID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_congThucs_nguyenLieus_NguyenLieuID",
                        column: x => x.NguyenLieuID,
                        principalTable: "nguyenLieus",
                        principalColumn: "NguyenLieuID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_congThucs_MonAnID",
                table: "congThucs",
                column: "MonAnID");

            migrationBuilder.CreateIndex(
                name: "IX_congThucs_NguyenLieuID",
                table: "congThucs",
                column: "NguyenLieuID");

            migrationBuilder.CreateIndex(
                name: "IX_monAns_LoaiMonAnID",
                table: "monAns",
                column: "LoaiMonAnID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "congThucs");

            migrationBuilder.DropTable(
                name: "monAns");

            migrationBuilder.DropTable(
                name: "nguyenLieus");

            migrationBuilder.DropTable(
                name: "loaiMonAns");
        }
    }
}
