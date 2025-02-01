using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StPeterCollectors.Migrations
{
    /// <inheritdoc />
    public partial class addTotalTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sp_total_all",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    account_total = table.Column<int>(type: "INTEGER", nullable: false),
                    qcomm_total = table.Column<decimal>(type: "TEXT", nullable: false),
                    qncomm_total = table.Column<decimal>(type: "TEXT", nullable: false),
                    collected_total = table.Column<int>(type: "INTEGER", nullable: false),
                    collection_total = table.Column<decimal>(type: "TEXT", nullable: false),
                    adv_collection_total = table.Column<decimal>(type: "TEXT", nullable: false),
                    comm_handl_fee = table.Column<decimal>(type: "TEXT", nullable: false),
                    ncomm_handl_fee = table.Column<decimal>(type: "TEXT", nullable: false),
                    quota_com_total = table.Column<decimal>(type: "TEXT", nullable: false),
                    quota_ncom_total = table.Column<decimal>(type: "TEXT", nullable: false),
                    total_quota = table.Column<decimal>(type: "TEXT", nullable: false),
                    total_tap = table.Column<decimal>(type: "TEXT", nullable: false),
                    total_balance = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sp_total_all", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sp_total_all");
        }
    }
}
