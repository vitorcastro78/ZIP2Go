using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Admin.Repository.Migrations.Admin
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RequestHeaders");
        }

        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RequestHeaders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    _async = table.Column<bool>(type: "INTEGER", nullable: true),
                    acceptEncoding = table.Column<string>(type: "TEXT", nullable: false),
                    contentEncoding = table.Column<string>(type: "TEXT", nullable: false),
                    idempotencyKey = table.Column<string>(type: "TEXT", nullable: false),
                    zuoraEntityIds = table.Column<string>(type: "TEXT", nullable: false),
                    zuoraTrackId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestHeaders", x => x.Id);
                });
        }
    }
}