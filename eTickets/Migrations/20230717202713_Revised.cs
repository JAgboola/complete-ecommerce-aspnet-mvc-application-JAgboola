using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class Revised : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Actors_ActorId",
                table: "Actors_Movies");

            migrationBuilder.DropIndex(
                name: "IX_Actors_Movies_ActorId",
                table: "Actors_Movies");

            migrationBuilder.RenameColumn(
                name: "ProducerId",
                table: "Producers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Movies",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CinemaId",
                table: "Cinemas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ActorId",
                table: "Actors",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "ActorId1",
                table: "Actors_Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Actors_Movies_ActorId1",
                table: "Actors_Movies",
                column: "ActorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Actors_ActorId1",
                table: "Actors_Movies",
                column: "ActorId1",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Actors_ActorId1",
                table: "Actors_Movies");

            migrationBuilder.DropIndex(
                name: "IX_Actors_Movies_ActorId1",
                table: "Actors_Movies");

            migrationBuilder.DropColumn(
                name: "ActorId1",
                table: "Actors_Movies");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Producers",
                newName: "ProducerId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Movies",
                newName: "MovieId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cinemas",
                newName: "CinemaId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Actors",
                newName: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_Actors_Movies_ActorId",
                table: "Actors_Movies",
                column: "ActorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Actors_ActorId",
                table: "Actors_Movies",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "ActorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
