using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StPeterCollectors.Migrations
{
    /// <inheritdoc />
    public partial class sp_total_all : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "sp_collectors_main",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "planType",
                table: "sp_collectors_main",
                newName: "tax");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "sp_collectors_main",
                newName: "plan_holder");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "sp_collectors_main",
                newName: "ins");

            migrationBuilder.AddColumn<int>(
                name: "aging",
                table: "sp_collectors_main",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "balance",
                table: "sp_collectors_main",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "cbi",
                table: "sp_collectors_main",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "coll_advance",
                table: "sp_collectors_main",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "coll_due",
                table: "sp_collectors_main",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "collector_name",
                table: "sp_collectors_main",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "contract_no",
                table: "sp_collectors_main",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "sp_collectors_main",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "due_date",
                table: "sp_collectors_main",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "effectivity_date",
                table: "sp_collectors_main",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "inst_no",
                table: "sp_collectors_main",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "or_date",
                table: "sp_collectors_main",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "or_no",
                table: "sp_collectors_main",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "quota_comm",
                table: "sp_collectors_main",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "quota_ncomm",
                table: "sp_collectors_main",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "aging",
                table: "sp_collectors_main");

            migrationBuilder.DropColumn(
                name: "balance",
                table: "sp_collectors_main");

            migrationBuilder.DropColumn(
                name: "cbi",
                table: "sp_collectors_main");

            migrationBuilder.DropColumn(
                name: "coll_advance",
                table: "sp_collectors_main");

            migrationBuilder.DropColumn(
                name: "coll_due",
                table: "sp_collectors_main");

            migrationBuilder.DropColumn(
                name: "collector_name",
                table: "sp_collectors_main");

            migrationBuilder.DropColumn(
                name: "contract_no",
                table: "sp_collectors_main");

            migrationBuilder.DropColumn(
                name: "description",
                table: "sp_collectors_main");

            migrationBuilder.DropColumn(
                name: "due_date",
                table: "sp_collectors_main");

            migrationBuilder.DropColumn(
                name: "effectivity_date",
                table: "sp_collectors_main");

            migrationBuilder.DropColumn(
                name: "inst_no",
                table: "sp_collectors_main");

            migrationBuilder.DropColumn(
                name: "or_date",
                table: "sp_collectors_main");

            migrationBuilder.DropColumn(
                name: "or_no",
                table: "sp_collectors_main");

            migrationBuilder.DropColumn(
                name: "quota_comm",
                table: "sp_collectors_main");

            migrationBuilder.DropColumn(
                name: "quota_ncomm",
                table: "sp_collectors_main");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "sp_collectors_main",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "tax",
                table: "sp_collectors_main",
                newName: "planType");

            migrationBuilder.RenameColumn(
                name: "plan_holder",
                table: "sp_collectors_main",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ins",
                table: "sp_collectors_main",
                newName: "Email");
        }
    }
}
