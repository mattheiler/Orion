using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.Data.Migrations
{
    public partial class Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "Qux",
                table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table => { table.PrimaryKey("PK_Qux", x => x.Id); });

            migrationBuilder.CreateTable(
                "User",
                table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table => { table.PrimaryKey("PK_User", x => x.Id); });

            migrationBuilder.CreateTable(
                "Foo",
                table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foo", x => x.Id);
                    table.ForeignKey(
                        "FK_Foo_User_UserId",
                        x => x.UserId,
                        "User",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "Bar",
                table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FooId = table.Column<int>(nullable: false),
                    ParentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bar", x => x.Id);
                    table.ForeignKey(
                        "FK_Bar_Foo_FooId",
                        x => x.FooId,
                        "Foo",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_Bar_Bar_ParentId",
                        x => x.ParentId,
                        "Bar",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                "Baz",
                table => new
                {
                    BarId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baz", x => x.BarId);
                    table.ForeignKey(
                        "FK_Baz_Bar_BarId",
                        x => x.BarId,
                        "Bar",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "BazQux",
                table => new
                {
                    BazId = table.Column<int>(nullable: false),
                    QuxId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BazQux", x => new { x.BazId, x.QuxId });
                    table.ForeignKey(
                        "FK_BazQux_Baz_BazId",
                        x => x.BazId,
                        "Baz",
                        "BarId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_BazQux_Qux_QuxId",
                        x => x.QuxId,
                        "Qux",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                "IX_Bar_FooId",
                "Bar",
                "FooId");

            migrationBuilder.CreateIndex(
                "IX_Bar_ParentId",
                "Bar",
                "ParentId");

            migrationBuilder.CreateIndex(
                "IX_BazQux_QuxId",
                "BazQux",
                "QuxId");

            migrationBuilder.CreateIndex(
                "IX_Foo_UserId",
                "Foo",
                "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "BazQux");

            migrationBuilder.DropTable(
                "Baz");

            migrationBuilder.DropTable(
                "Qux");

            migrationBuilder.DropTable(
                "Bar");

            migrationBuilder.DropTable(
                "Foo");

            migrationBuilder.DropTable(
                "User");
        }
    }
}