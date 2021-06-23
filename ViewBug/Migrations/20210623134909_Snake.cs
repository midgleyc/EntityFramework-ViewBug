using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ViewBug.Migrations
{
    public partial class Snake : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_jobs",
                table: "jobs");

            migrationBuilder.AddPrimaryKey(
                name: "pk_jobs",
                table: "jobs",
                column: "id");

            migrationBuilder.CreateTable(
                name: "job_views",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_job_views", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "job_views");

            migrationBuilder.DropPrimaryKey(
                name: "pk_jobs",
                table: "jobs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_jobs",
                table: "jobs",
                column: "id");
        }
    }
}
