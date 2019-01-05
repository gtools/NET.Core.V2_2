using Microsoft.EntityFrameworkCore.Migrations;

namespace NET.Core.V2_2.Data.Migrations
{
    public partial class SYS_Navbar3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "SYS_Navbar",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SYS_Navbar",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValue: "#");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "SYS_Navbar",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SYS_Navbar",
                maxLength: 50,
                nullable: false,
                defaultValue: "#",
                oldClrType: typeof(string),
                oldMaxLength: 50);
        }
    }
}
