using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmsStoreMvc.Migrations
{
    /// <inheritdoc />
    public partial class hicham : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Film",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Studio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CritiqueScore = table.Column<int>(type: "int", nullable: false),
                    AudienceScore = table.Column<int>(type: "int", nullable: false),
                    Directeur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActeurPrincipal = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Film");
        }
    }
}
