using Microsoft.EntityFrameworkCore.Migrations;

namespace NET.Core.V2_2.Data.Migrations
{
    public partial class Emp_Dept : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AddColumn<string>(
                name: "Emp_Code",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.CreateTable(
                name: "SYS_Dept",
                columns: table => new
                {
                    Dept_Code = table.Column<string>(maxLength: 50, nullable: false),
                    Dept_Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYS_Dept", x => x.Dept_Code);
                });

            migrationBuilder.CreateTable(
                name: "SYS_Emp",
                columns: table => new
                {
                    Emp_Code = table.Column<string>(maxLength: 50, nullable: false),
                    Emp_Name = table.Column<string>(maxLength: 50, nullable: false),
                    Dept_Code = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYS_Emp", x => x.Emp_Code);
                    table.ForeignKey(
                        name: "FK_SYS_Emp_SYS_Dept_Dept_Code",
                        column: x => x.Dept_Code,
                        principalTable: "SYS_Dept",
                        principalColumn: "Dept_Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Emp_Code",
                table: "AspNetUsers",
                column: "Emp_Code");

            migrationBuilder.CreateIndex(
                name: "IX_SYS_Emp_Dept_Code",
                table: "SYS_Emp",
                column: "Dept_Code");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_SYS_Emp_Emp_Code",
                table: "AspNetUsers",
                column: "Emp_Code",
                principalTable: "SYS_Emp",
                principalColumn: "Emp_Code",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_SYS_Emp_Emp_Code",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "SYS_Emp");

            migrationBuilder.DropTable(
                name: "SYS_Dept");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Emp_Code",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Emp_Code",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
