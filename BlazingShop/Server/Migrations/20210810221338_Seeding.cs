using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazingShop.Server.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "book", "Books", "books" },
                    { 2, "aperture", "Video Games", "video-games" },
                    { 3, "camera-slr", "Electronics", "electronics" },
                    { 4, "tag", "Movies", "movies" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "OriginalPrice", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 8, 11, 3, 43, 38, 286, DateTimeKind.Local).AddTicks(7794), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The son of a zookeeper, Pi Patel has an encyclopedic knowledge of animal behavior and a fervent love of stories. When Pi is sixteen, his family emigrates from India to North America aboard a Japanese cargo ship, along with their zoo animals bound for new homes", "https://upload.wikimedia.org/wikipedia/en/4/45/Life_of_Pi_cover.png", false, false, 10.99m, 9.99m, "Life Of Pie" },
                    { 2, 2, new DateTime(2021, 8, 11, 3, 43, 38, 289, DateTimeKind.Local).AddTicks(32), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The game takes place in Hope County, a fictional region of Montana, United States. The main story revolves around the Project at Eden's Gate, a doomsday cult that has taken over the county at the command of its charismatic and powerful leader, Joseph Seed. ", "https://upload.wikimedia.org/wikipedia/en/0/03/Far_Cry_5_boxshot.jpg", false, false, 39.99m, 8.19m, "Farcry 5" },
                    { 3, 3, new DateTime(2021, 8, 11, 3, 43, 38, 289, DateTimeKind.Local).AddTicks(52), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The PlayStation 5 (PS5) is a home video game console developed by Sony Interactive Entertainment. Announced in 2019 as the successor to the PlayStation 4, the PS5 was released on November 12, 2020", "https://upload.wikimedia.org/wikipedia/commons/1/1b/PlayStation_5_and_DualSense_with_transparent_background.png", false, false, 499.99m, 399.99m, "Playstation 5 (PS5)" },
                    { 4, 4, new DateTime(2021, 8, 11, 3, 43, 38, 289, DateTimeKind.Local).AddTicks(54), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sarpatta Parambarai, or alternatively Sarpatta tradition, is a 2021 Indian Tamil-language sports action film directed by Pa. Ranjith, who also co-produced the film under his banner Neelam Productions", "https://upload.wikimedia.org/wikipedia/en/a/a6/Sarpatta_Parambarai.jpg", false, false, 40.29m, 20.19m, "Sarpatta Parambarai" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
