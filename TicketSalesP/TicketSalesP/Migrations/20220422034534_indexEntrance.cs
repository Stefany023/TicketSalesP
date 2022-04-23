using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketSalesP.Migrations
{
    public partial class indexEntrance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Entrances_Description",
                table: "Entrances",
                column: "Description",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Entrances_Description",
                table: "Entrances");
        }
    }
}
