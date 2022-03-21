using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.DAL.Migrations
{
    public partial class db_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalRequest",
                table: "RequestProducts",
                newName: "TotalProducts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalProducts",
                table: "RequestProducts",
                newName: "TotalRequest");
        }
    }
}
