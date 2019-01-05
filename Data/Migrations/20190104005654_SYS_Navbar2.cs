using Microsoft.EntityFrameworkCore.Migrations;

namespace NET.Core.V2_2.Data.Migrations
{
    public partial class SYS_Navbar2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SYS_Navbar",
                maxLength: 50,
                nullable: false,
                defaultValue: "#",
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "Action",
                table: "SYS_Navbar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Controller",
                table: "SYS_Navbar",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Action",
                table: "SYS_Navbar");

            migrationBuilder.DropColumn(
                name: "Controller",
                table: "SYS_Navbar");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SYS_Navbar",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValue: "#");
        }
    }
}
