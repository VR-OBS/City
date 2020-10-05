using Microsoft.EntityFrameworkCore.Migrations;

namespace City.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Cards_ContractorID",
                table: "Cards",
                column: "ContractorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Contractors_ContractorID",
                table: "Cards",
                column: "ContractorID",
                principalTable: "Contractors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Contractors_ContractorID",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Cards_ContractorID",
                table: "Cards");
        }
    }
}
