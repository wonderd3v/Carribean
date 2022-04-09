using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carribean.API.Migrations
{
    public partial class updatingticketuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MovieName",
                table: "Ticket",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Schedule",
                table: "Ticket",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Seat",
                table: "Ticket",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TicketPrice",
                table: "Ticket",
                type: "decimal(18,2)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MovieName",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "Schedule",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "Seat",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "TicketPrice",
                table: "Ticket");
        }
    }
}
