using Microsoft.EntityFrameworkCore.Migrations;

namespace QLNhanVienEF.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "duAns",
                columns: table => new
                {
                    DuAnId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDuAn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_duAns", x => x.DuAnId);
                });

            migrationBuilder.CreateTable(
                name: "nhanViens",
                columns: table => new
                {
                    NhanVienId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sdt = table.Column<int>(type: "int", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeSoLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nhanViens", x => x.NhanVienId);
                });

            migrationBuilder.CreateTable(
                name: "phanCongs",
                columns: table => new
                {
                    PhanCongId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NhanVienId = table.Column<int>(type: "int", nullable: false),
                    DuAnId = table.Column<int>(type: "int", nullable: false),
                    SoGioLam = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phanCongs", x => x.PhanCongId);
                    table.ForeignKey(
                        name: "FK_phanCongs_duAns_DuAnId",
                        column: x => x.DuAnId,
                        principalTable: "duAns",
                        principalColumn: "DuAnId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_phanCongs_nhanViens_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "nhanViens",
                        principalColumn: "NhanVienId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_phanCongs_DuAnId",
                table: "phanCongs",
                column: "DuAnId");

            migrationBuilder.CreateIndex(
                name: "IX_phanCongs_NhanVienId",
                table: "phanCongs",
                column: "NhanVienId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "phanCongs");

            migrationBuilder.DropTable(
                name: "duAns");

            migrationBuilder.DropTable(
                name: "nhanViens");
        }
    }
}
