using Microsoft.EntityFrameworkCore.Migrations;

namespace City.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_TypeCard_TypeCardID",
                table: "Cards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TypeCard",
                table: "TypeCard");

            migrationBuilder.RenameTable(
                name: "TypeCard",
                newName: "TypesCard");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TypesCard",
                table: "TypesCard",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_TypesCard_TypeCardID",
                table: "Cards",
                column: "TypeCardID",
                principalTable: "TypesCard",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_TypesCard_TypeCardID",
                table: "Cards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TypesCard",
                table: "TypesCard");

            migrationBuilder.RenameTable(
                name: "TypesCard",
                newName: "TypeCard");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TypeCard",
                table: "TypeCard",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_TypeCard_TypeCardID",
                table: "Cards",
                column: "TypeCardID",
                principalTable: "TypeCard",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
