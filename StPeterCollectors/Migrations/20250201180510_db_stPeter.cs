using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StPeterCollectors.Migrations
{
    /// <inheritdoc />
    public partial class db_stPeter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "planType",
                table: "Collectors",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "planType",
                table: "Collectors");
        }
    }
}
