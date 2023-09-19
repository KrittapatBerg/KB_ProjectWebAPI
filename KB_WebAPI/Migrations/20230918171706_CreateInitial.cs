using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KB_WebAPI.Migrations
{
    public partial class CreateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Attractions_AttractionId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Rating_Attractions_AttractionId",
                table: "Rating");

            migrationBuilder.DropForeignKey(
                name: "FK_Rating_Users_UserId1",
                table: "Rating");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rating",
                table: "Rating");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.RenameTable(
                name: "Rating",
                newName: "Ratings");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "Addresses");

            migrationBuilder.RenameIndex(
                name: "IX_Rating_UserId1",
                table: "Ratings",
                newName: "IX_Ratings_UserId1");

            migrationBuilder.RenameIndex(
                name: "IX_Rating_AttractionId",
                table: "Ratings",
                newName: "IX_Ratings_AttractionId");

            migrationBuilder.RenameIndex(
                name: "IX_Address_AttractionId",
                table: "Addresses",
                newName: "IX_Addresses_AttractionId");

            migrationBuilder.AddColumn<bool>(
                name: "Seeded",
                table: "Attractions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Seeded",
                table: "Addresses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ratings",
                table: "Ratings",
                column: "RatingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Attractions_AttractionId",
                table: "Addresses",
                column: "AttractionId",
                principalTable: "Attractions",
                principalColumn: "AttractionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Attractions_AttractionId",
                table: "Ratings",
                column: "AttractionId",
                principalTable: "Attractions",
                principalColumn: "AttractionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Users_UserId1",
                table: "Ratings",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Attractions_AttractionId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Attractions_AttractionId",
                table: "Ratings");

            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Users_UserId1",
                table: "Ratings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ratings",
                table: "Ratings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "Seeded",
                table: "Attractions");

            migrationBuilder.DropColumn(
                name: "Seeded",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "Ratings",
                newName: "Rating");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "Address");

            migrationBuilder.RenameIndex(
                name: "IX_Ratings_UserId1",
                table: "Rating",
                newName: "IX_Rating_UserId1");

            migrationBuilder.RenameIndex(
                name: "IX_Ratings_AttractionId",
                table: "Rating",
                newName: "IX_Rating_AttractionId");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_AttractionId",
                table: "Address",
                newName: "IX_Address_AttractionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rating",
                table: "Rating",
                column: "RatingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Attractions_AttractionId",
                table: "Address",
                column: "AttractionId",
                principalTable: "Attractions",
                principalColumn: "AttractionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_Attractions_AttractionId",
                table: "Rating",
                column: "AttractionId",
                principalTable: "Attractions",
                principalColumn: "AttractionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_Users_UserId1",
                table: "Rating",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
