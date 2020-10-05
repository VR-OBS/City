using Microsoft.EntityFrameworkCore.Migrations;

namespace City.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Cards_StatusID",
                table: "Cards",
                column: "StatusID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Statuses_StatusID",
                table: "Cards",
                column: "StatusID",
                principalTable: "Statuses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Statuses_StatusID",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Cards_StatusID",
                table: "Cards");
        }
    }
}
