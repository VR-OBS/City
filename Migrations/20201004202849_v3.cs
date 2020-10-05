using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace City.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TypeCardID",
                table: "Cards",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TypeCard",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeCard", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_TypeCardID",
                table: "Cards",
                column: "TypeCardID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_TypeCard_TypeCardID",
                table: "Cards",
                column: "TypeCardID",
                principalTable: "TypeCard",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_TypeCard_TypeCardID",
                table: "Cards");

            migrationBuilder.DropTable(
                name: "TypeCard");

            migrationBuilder.DropIndex(
                name: "IX_Cards_TypeCardID",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "TypeCardID",
                table: "Cards");
        }
    }
}
