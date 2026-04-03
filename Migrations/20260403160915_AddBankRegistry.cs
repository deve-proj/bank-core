using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace bank_core.Migrations
{
    /// <inheritdoc />
    public partial class AddBankRegistry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bank_registry",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    bank_id = table.Column<string>(type: "text", nullable: false),
                    bank_name = table.Column<string>(type: "text", nullable: false),
                    api_url = table.Column<string>(type: "text", nullable: false),
                    registered_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    owner_id = table.Column<string>(type: "text", nullable: false),
                    contact_email = table.Column<string>(type: "text", nullable: false),
                    status = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("id", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "ix_bank_registry_bank_name",
                table: "bank_registry",
                column: "bank_name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bank_registry");
        }
    }
}
