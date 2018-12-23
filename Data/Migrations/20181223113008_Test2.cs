using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NET.Core.V2_2.Data.Migrations
{
    public partial class Test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Test2s",
                columns: table => new
                {
                    Tid = table.Column<Guid>(nullable: false, defaultValueSql: "newsequentialid()"),
                    Address = table.Column<string>(nullable: true),
                    Explain = table.Column<string>(nullable: true),
                    Sort = table.Column<int>(maxLength: 5, nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test2s", x => x.Tid);
                });

            migrationBuilder.InsertData(
                table: "Test2s",
                columns: new[] { "Tid", "Address", "Explain" },
                values: new object[] { new Guid("61d8230f-7b89-4f15-8e79-ae65966a929e"), "1", "1" });

            migrationBuilder.InsertData(
                table: "Test2s",
                columns: new[] { "Tid", "Address", "Explain" },
                values: new object[] { new Guid("31975595-26e5-47c1-bb8c-21b579a11b6b"), "2", "1" });

            migrationBuilder.InsertData(
                table: "Test2s",
                columns: new[] { "Tid", "Address", "Explain" },
                values: new object[] { new Guid("17ba4f00-ed3a-4a2f-9a2f-26bdb9f11420"), "3", "4" });

            migrationBuilder.InsertData(
                table: "Test2s",
                columns: new[] { "Tid", "Address", "Explain" },
                values: new object[] { new Guid("c4fb37e8-9f4d-40a8-b469-06b026e682a4"), "5", "5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Test2s");
        }
    }
}
