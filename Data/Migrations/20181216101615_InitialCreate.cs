using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NET.Core.V2_2.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FTP_Page",
                columns: table => new
                {
                    PId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(maxLength: 50, nullable: false),
                    Explain = table.Column<string>(maxLength: 50, nullable: true),
                    Sort = table.Column<int>(maxLength: 5, nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FTP_Page", x => x.PId);
                });

            migrationBuilder.CreateTable(
                name: "FTP_FileGroup",
                columns: table => new
                {
                    FGId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Sort = table.Column<int>(maxLength: 5, nullable: false, defaultValue: 0),
                    PId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FTP_FileGroup", x => x.FGId);
                    table.ForeignKey(
                        name: "FK_FTP_FileGroup_FTP_Page_PId",
                        column: x => x.PId,
                        principalTable: "FTP_Page",
                        principalColumn: "PId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FTP_FileUrl",
                columns: table => new
                {
                    FUId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Url = table.Column<string>(maxLength: 50, nullable: false),
                    Sort = table.Column<int>(maxLength: 5, nullable: false, defaultValue: 0),
                    FGId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FTP_FileUrl", x => x.FUId);
                    table.ForeignKey(
                        name: "FK_FTP_FileUrl_FTP_FileGroup_FGId",
                        column: x => x.FGId,
                        principalTable: "FTP_FileGroup",
                        principalColumn: "FGId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FTP_FileGroup_PId",
                table: "FTP_FileGroup",
                column: "PId");

            migrationBuilder.CreateIndex(
                name: "IX_FTP_FileUrl_FGId",
                table: "FTP_FileUrl",
                column: "FGId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FTP_FileUrl");

            migrationBuilder.DropTable(
                name: "FTP_FileGroup");

            migrationBuilder.DropTable(
                name: "FTP_Page");
        }
    }
}
