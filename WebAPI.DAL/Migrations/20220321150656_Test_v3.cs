using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.DAL.Migrations
{
    public partial class Test_v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authorization_Authentication__AuthencationId",
                table: "Authorization");

            migrationBuilder.RenameColumn(
                name: "_AuthencationId",
                table: "Authorization",
                newName: "AuthencationId");

            migrationBuilder.RenameIndex(
                name: "IX_Authorization__AuthencationId",
                table: "Authorization",
                newName: "IX_Authorization_AuthencationId");

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeToken",
                table: "Authentication",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Money",
                table: "Accounts",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_AccountId",
                table: "Products",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Authorization_Authentication_AuthencationId",
                table: "Authorization",
                column: "AuthencationId",
                principalTable: "Authentication",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Accounts_AccountId",
                table: "Products",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Category_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authorization_Authentication_AuthencationId",
                table: "Authorization");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Accounts_AccountId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Category_CategoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Products_AccountId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TypeToken",
                table: "Authentication");

            migrationBuilder.DropColumn(
                name: "Money",
                table: "Accounts");

            migrationBuilder.RenameColumn(
                name: "AuthencationId",
                table: "Authorization",
                newName: "_AuthencationId");

            migrationBuilder.RenameIndex(
                name: "IX_Authorization_AuthencationId",
                table: "Authorization",
                newName: "IX_Authorization__AuthencationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Authorization_Authentication__AuthencationId",
                table: "Authorization",
                column: "_AuthencationId",
                principalTable: "Authentication",
                principalColumn: "Id");
        }
    }
}
