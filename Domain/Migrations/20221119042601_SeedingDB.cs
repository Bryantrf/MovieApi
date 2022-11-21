using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Review = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Cancelled", "Gender", "Name" },
                values: new object[,]
                {
                    { 1, false, "Fantasy", "Andalusian Dog, An (Chien andalou, Un)" },
                    { 2, false, "Action|Adventure|Comedy|Romance|Thriller", "Lara Croft Tomb Raider: The Cradle of Life" },
                    { 3, false, "Drama|Thriller", "Bottom of the Sea, The (El fondo del mar)" },
                    { 4, false, "Comedy|Romance", "Auntie from Chicago, The (I theia apo to Chicago)" },
                    { 5, false, "Action|Thriller", "Way of War, The" },
                    { 6, true, "Thriller", "State Affairs (Une affaire d'état)" },
                    { 7, false, "Drama", "Canvas" },
                    { 8, false, "Drama|Romance", "Last Tycoon, The" },
                    { 9, false, "Action|Sci-Fi", "King Kong vs. Godzilla (Kingukongu tai Gojira)" },
                    { 10, true, "Action|Crime|Drama|Thriller", "Tesseract, The" },
                    { 11, false, "Action|Romance", "Once Upon a Time in China II (Wong Fei-hung Ji Yi: Naam yi dong ji keung)" },
                    { 12, true, "Comedy|Fantasy|Romance", "Topper" },
                    { 13, false, "Comedy", "Spy Hard" },
                    { 14, false, "Comedy|Musical", "Stand Up and Cheer!" },
                    { 15, false, "Comedy|Thriller", "Helsinki Napoli All Night Long" },
                    { 16, true, "Comedy", "The Pool Boys" },
                    { 17, true, "Animation|Children|Comedy|Crime", "Wallace & Gromit: The Wrong Trousers" },
                    { 18, false, "Comedy", "King of California" },
                    { 19, true, "Drama|Thriller|War", "Thirteen Days" },
                    { 20, false, "Horror|Thriller", "Hostel: Part III " },
                    { 21, false, "Crime|Drama|Thriller", "The Rise" },
                    { 22, true, "Drama", "Wife! Be Like a Rose! (Tsuma yo bara no yo ni)" },
                    { 23, true, "Drama", "Horse Rebellion, The (Pulakapina)" },
                    { 24, true, "Comedy|Crime|Mystery", "Curse of the Pink Panther" },
                    { 25, true, "Drama", "Passionate Friends, The (a.k.a. One Woman's Story)" },
                    { 26, false, "Drama|Romance|War", "Doctor Zhivago" },
                    { 27, false, "Drama|Romance", "Elementary Particles, The (Elementarteilchen)" },
                    { 28, false, "Adventure", "Buccaneer, The" },
                    { 29, true, "Crime|Thriller", "Sudden Impact" },
                    { 30, true, "Romance|Thriller", "Kill Me Later" },
                    { 31, true, "Action|Sci-Fi", "King of Fighters, The" },
                    { 32, false, "Comedy|Drama", "Woman, a Gun and a Noodle Shop, A (San qiang pai an jing qi)" },
                    { 33, false, "Action", "Best of the Best 2" },
                    { 34, true, "Action|Horror|Sci-Fi", "Doom" },
                    { 35, false, "Adventure", "Brenda Starr" },
                    { 36, false, "Comedy|Mystery", "Private Eyes, The" },
                    { 37, false, "Animation|Children|Fantasy", "Care Bears Movie, The" },
                    { 38, true, "Comedy", "First Wives Club, The" },
                    { 39, false, "Drama", "Hot Saturday" },
                    { 40, false, "Drama|War", "Ivan's Childhood (a.k.a. My Name is Ivan) (Ivanovo detstvo)" },
                    { 41, true, "Action|Comedy|Crime|Thriller", "Ca$h" },
                    { 42, false, "Drama", "Insect Woman, The (Nippon konchûki)" },
                    { 43, true, "Drama", "Promised Life, The (Vie promise, La)" },
                    { 44, true, "Adventure|Comedy|Fantasy|Romance|IMAX", "Journey to the West: Conquering the Demons (Daai wa sai you chi Chui mo chun kei)" },
                    { 45, true, "Adventure|Drama|Fantasy", "Sophie's World (Sofies verden)" },
                    { 46, true, "Horror", "ABCs of Death, The" },
                    { 47, false, "Horror|Sci-Fi", "Frozen Dead, The" },
                    { 48, false, "Comedy|Drama", "Linda Linda Linda" },
                    { 49, true, "Comedy", "Garage, The" },
                    { 50, true, "Comedy", "Owl and the Pussycat, The" },
                    { 51, true, "Horror|Sci-Fi", "Carnosaur" },
                    { 52, false, "Drama|Mystery|Thriller", "Turks & Caicos" },
                    { 53, false, "Documentary", "Iran Is Not the Problem" },
                    { 54, true, "Drama|Musical", "Stomp the Yard" },
                    { 55, true, "Comedy|Horror|Thriller", "Housebound" },
                    { 56, true, "Drama|Musical", "Georg" },
                    { 57, true, "Action|Adventure|Drama", "Tomorrow, When the War Began" },
                    { 58, false, "Drama", "Human Capital (Il capitale umano)" },
                    { 59, false, "Crime|Drama|Romance", "Nordkraft" },
                    { 60, true, "Drama|Romance", "Spread" },
                    { 61, false, "Comedy", "Skin Deep" },
                    { 62, false, "Comedy|Drama|Romance", "Postman, The (Postino, Il)" },
                    { 63, false, "Drama", "From the Clouds to the Resistance (Dalla nube alla resistenza)" },
                    { 64, false, "Action|Drama|Fantasy", "Promise, The (Wu ji)" },
                    { 65, true, "Action", "Confessions of a Gangsta" },
                    { 66, true, "Children|Musical", "Teen Beach Movie" },
                    { 67, true, "Action|Thriller", "Point of No Return" },
                    { 68, true, "Documentary", "Sam Peckinpah: Man of Iron" },
                    { 69, true, "Drama|Fantasy|Romance", "Orlando" },
                    { 70, false, "Comedy|Romance", "Black Coffee" },
                    { 71, false, "Action|Drama|War", "Saints and Soldiers: Airborne Creed" },
                    { 72, false, "Drama", "End of St. Petersburg, The (Konets Sankt-Peterburga)" },
                    { 73, true, "Crime|Drama", "Johnny Handsome" },
                    { 74, false, "Sci-Fi", "Noah's Arc Principle, The (Arche Noah Prinzip, Das)" },
                    { 75, false, "Comedy", "HealtH" },
                    { 76, false, "Drama|Romance", "Love and Basketball" },
                    { 77, true, "Comedy|Drama", "All Together" },
                    { 78, false, "Action|Crime", "Electra Glide in Blue" },
                    { 79, false, "Comedy|Musical", "Adventures of Power" },
                    { 80, true, "Action|Adventure|Fantasy|IMAX", "Oz the Great and Powerful" },
                    { 81, true, "Documentary", "Armstrong Lie, The" },
                    { 82, false, "Drama|War", "Nicholas and Alexandra" },
                    { 83, false, "Comedy", "Page Miss Glory" },
                    { 84, false, "Documentary", "Manufactured Landscapes" },
                    { 85, true, "Documentary", "English Surgeon, The" },
                    { 86, true, "Drama|Fantasy", "Magic Sword, The" },
                    { 87, true, "Comedy|Drama", "Color of Friendship, The" },
                    { 88, false, "Drama", "Hotel New Hampshire, The" },
                    { 89, true, "Comedy", "Yolki 2" },
                    { 90, false, "Crime|Drama|Film-Noir|Mystery|Thriller", "Mulholland Drive" },
                    { 91, false, "Action|Drama", "Zatoichi's Vengeance (Zatôichi no uta ga kikoeru) (Zatôichi 13)" },
                    { 92, true, "Comedy", "Louis C.K.: Live at The Comedy Store" },
                    { 93, false, "Drama|Thriller", "Debt, The" },
                    { 94, true, "Drama", "The Puzzle" },
                    { 95, false, "Documentary", "McCullin" },
                    { 96, true, "(no genres listed)", "Istanbul" },
                    { 97, false, "Action|Adventure", "36th Chamber of Shaolin, The (Shao Lin san shi liu fang) (Master Killer)" },
                    { 98, true, "Comedy|Drama", "Daddy and Them" },
                    { 99, false, "Horror", "Prowler, The (a.k.a. Rosemary's Killer) (a.k.a. The Graduation)" },
                    { 100, true, "Drama", "Warped Ones, The (Kyonetsu no kisetsu)" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Reviews");
        }
    }
}
