using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.DAL.Migrations
{
    public partial class Test_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Total",
                table: "Products",
                newName: "TotalProduct");

            migrationBuilder.AddColumn<int>(
                name: "TotalRequest",
                table: "RequestProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Content",
                table: "FileImages",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalRequest",
                table: "RequestProducts");

            migrationBuilder.RenameColumn(
                name: "TotalProduct",
                table: "Products",
                newName: "Total");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Content",
                table: "FileImages",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");
        }
    }
}
