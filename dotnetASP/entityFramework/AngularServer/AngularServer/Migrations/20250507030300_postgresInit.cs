using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AngularServer.Migrations
{
    /// <inheritdoc />
    public partial class postgresInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PaymentDetails",
                columns: table => new
                {
                    PaymentDetailId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CardOwnerName = table.Column<string>(type: "varchar(100)", nullable: true),
                    CardNumber = table.Column<string>(type: "varchar(16)", nullable: true),
                    ExpirationDate = table.Column<string>(type: "varchar(5)", nullable: true),
                    SecurityCode = table.Column<string>(type: "varchar(3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentDetails", x => x.PaymentDetailId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentDetails");
        }
    }
}
