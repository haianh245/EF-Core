using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QL_HocSinh_EF01.Migrations
{
    public partial class intitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "lops",
                columns: table => new
                {
                    LopID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiSo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lops", x => x.LopID);
                });

            migrationBuilder.CreateTable(
                name: "hocSinhs",
                columns: table => new
                {
                    HocSinhID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LopID = table.Column<int>(type: "int", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QueQuan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hocSinhs", x => x.HocSinhID);
                    table.ForeignKey(
                        name: "FK_hocSinhs_lops_LopID",
                        column: x => x.LopID,
                        principalTable: "lops",
                        principalColumn: "LopID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_hocSinhs_LopID",
                table: "hocSinhs",
                column: "LopID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "hocSinhs");

            migrationBuilder.DropTable(
                name: "lops");
        }
    }
}
