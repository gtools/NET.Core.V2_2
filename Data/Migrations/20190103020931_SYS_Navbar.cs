using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NET.Core.V2_2.Data.Migrations
{
    public partial class SYS_Navbar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SYS_Navbar",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Url = table.Column<string>(nullable: false),
                    Sort = table.Column<int>(nullable: false, defaultValue: 0),
                    Is_Stop = table.Column<bool>(nullable: false, defaultValue: false),
                    ParentId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYS_Navbar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SYS_Navbar_SYS_Navbar_ParentId",
                        column: x => x.ParentId,
                        principalTable: "SYS_Navbar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SYS_Navbar_ParentId",
                table: "SYS_Navbar",
                column: "ParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SYS_Navbar");
        }
    }
}
