using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NET.Core.V2_2.Data.Migrations
{
    public partial class Test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Test1s",
                columns: table => new
                {
                    Tid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    Address = table.Column<string>(maxLength: 50, nullable: false),
                    Explain = table.Column<string>(maxLength: 50, nullable: true),
                    Sort = table.Column<int>(maxLength: 5, nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test1s", x => x.Tid);
                });

            migrationBuilder.InsertData(
                table: "Test1s",
                columns: new[] { "Tid", "Address", "Explain" },
                values: new object[] { new Guid("a1952052-7fdc-411d-86e3-dade962fb790"), "http://sample.com", "fds" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Test1s");
        }
    }
}
