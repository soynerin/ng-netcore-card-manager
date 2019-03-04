using Microsoft.EntityFrameworkCore.Migrations;

namespace CardManagerCore.Migrations
{
    public partial class FixInitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CCV",
                table: "PaymentDetails",
                newName: "CVV");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CVV",
                table: "PaymentDetails",
                newName: "CCV");
        }
    }
}
