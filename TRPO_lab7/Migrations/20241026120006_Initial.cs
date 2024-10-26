using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TRPO_lab7.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artist",
                columns: table => new
                {
                    artistID = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    biography = table.Column<string>(type: "text", nullable: true),
                    telegram = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    vk = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    email = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    phone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Artist__4F439367D89E7DD8", x => x.artistID);
                });

            migrationBuilder.CreateTable(
                name: "ArtOrder",
                columns: table => new
                {
                    artOrderID = table.Column<int>(type: "int", nullable: false),
                    artistID = table.Column<int>(type: "int", nullable: false),
                    customerFullName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    customerPhone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    customerEmail = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    socialMediaLink = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    artworkDescription = table.Column<string>(type: "text", nullable: false),
                    canvasSize = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    additionalRequests = table.Column<string>(type: "text", nullable: true),
                    deadline = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ArtOrder__64ED6C94495D2E9F", x => x.artOrderID);
                    table.ForeignKey(
                        name: "FK__ArtOrder__artist__2F10007B",
                        column: x => x.artistID,
                        principalTable: "Artist",
                        principalColumn: "artistID");
                });

            migrationBuilder.CreateTable(
                name: "Artwork",
                columns: table => new
                {
                    artworkID = table.Column<int>(type: "int", nullable: false),
                    artistID = table.Column<int>(type: "int", nullable: false),
                    artworkURL = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    title = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    canvasSize = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    description = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    price = table.Column<decimal>(type: "decimal(10,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Artwork__09DA4903253991F4", x => x.artworkID);
                    table.ForeignKey(
                        name: "FK__Artwork__artistI__267ABA7A",
                        column: x => x.artistID,
                        principalTable: "Artist",
                        principalColumn: "artistID");
                });

            migrationBuilder.CreateTable(
                name: "PortfolioArtwork",
                columns: table => new
                {
                    portfolioArtworkID = table.Column<int>(type: "int", nullable: false),
                    artistID = table.Column<int>(type: "int", nullable: false),
                    artworkURL = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    title = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    canvasSize = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    description = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Portfoli__5513D49346A71F13", x => x.portfolioArtworkID);
                    table.ForeignKey(
                        name: "FK__Portfolio__artis__2C3393D0",
                        column: x => x.artistID,
                        principalTable: "Artist",
                        principalColumn: "artistID");
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    reviewID = table.Column<int>(type: "int", nullable: false),
                    artistID = table.Column<int>(type: "int", nullable: false),
                    reviewText = table.Column<string>(type: "text", nullable: false),
                    reviewerName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    submissionDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Review__2ECD6E24E879D40A", x => x.reviewID);
                    table.ForeignKey(
                        name: "FK__Review__artistID__31EC6D26",
                        column: x => x.artistID,
                        principalTable: "Artist",
                        principalColumn: "artistID");
                });

            migrationBuilder.CreateTable(
                name: "ArtworkPurchase",
                columns: table => new
                {
                    atworkPurchaseID = table.Column<int>(type: "int", nullable: false),
                    artworkID = table.Column<int>(type: "int", nullable: false),
                    deliveryAddress = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    customerFullName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    customerPhone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    orderDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ArtworkP__34B426C0BB959372", x => x.atworkPurchaseID);
                    table.ForeignKey(
                        name: "FK__ArtworkPu__artwo__29572725",
                        column: x => x.artworkID,
                        principalTable: "Artwork",
                        principalColumn: "artworkID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArtOrder_artistID",
                table: "ArtOrder",
                column: "artistID");

            migrationBuilder.CreateIndex(
                name: "IX_Artwork_artistID",
                table: "Artwork",
                column: "artistID");

            migrationBuilder.CreateIndex(
                name: "IX_ArtworkPurchase_artworkID",
                table: "ArtworkPurchase",
                column: "artworkID");

            migrationBuilder.CreateIndex(
                name: "IX_PortfolioArtwork_artistID",
                table: "PortfolioArtwork",
                column: "artistID");

            migrationBuilder.CreateIndex(
                name: "IX_Review_artistID",
                table: "Review",
                column: "artistID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtOrder");

            migrationBuilder.DropTable(
                name: "ArtworkPurchase");

            migrationBuilder.DropTable(
                name: "PortfolioArtwork");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "Artwork");

            migrationBuilder.DropTable(
                name: "Artist");
        }
    }
}
