using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection.Metadata;

namespace Domain.Data
{
	public class BsMovieContext : DbContext
    {
        public DbSet<Movies> Movies { get; set; }
        public DbSet<Reviews> Reviews { get; set; }


        public BsMovieContext(DbContextOptions<BsMovieContext> op) : base(op)
		{
		}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Movies>().HasData(
                new Movies
                {
                    Id = 1,
                    Name = "Andalusian Dog, An (Chien andalou, Un)",
                    Gender = "Fantasy",
                    Cancelled = false
                }, new Movies
                {
                    Id = 2,
                    Name = "Lara Croft Tomb Raider: The Cradle of Life",
                    Gender = "Action|Adventure|Comedy|Romance|Thriller",
                    Cancelled = false
                }, new Movies
                {
                    Id = 3,
                    Name = "Bottom of the Sea, The (El fondo del mar)",
                    Gender = "Drama|Thriller",
                    Cancelled = false
                }, new Movies
                {
                    Id = 4,
                    Name = "Auntie from Chicago, The (I theia apo to Chicago)",
                    Gender = "Comedy|Romance",
                    Cancelled = false
                }, new Movies
                {
                    Id = 5,
                    Name = "Way of War, The",
                    Gender = "Action|Thriller",
                    Cancelled = false
                }, new Movies
                {
                    Id = 6,
                    Name = "State Affairs (Une affaire d'état)",
                    Gender = "Thriller",
                    Cancelled = true
                }, new Movies
                {
                    Id = 7,
                    Name = "Canvas",
                    Gender = "Drama",
                    Cancelled = false
                }, new Movies
                {
                    Id = 8,
                    Name = "Last Tycoon, The",
                    Gender = "Drama|Romance",
                    Cancelled = false
                }, new Movies
                {
                    Id = 9,
                    Name = "King Kong vs. Godzilla (Kingukongu tai Gojira)",
                    Gender = "Action|Sci-Fi",
                    Cancelled = false
                }, new Movies
                {
                    Id = 10,
                    Name = "Tesseract, The",
                    Gender = "Action|Crime|Drama|Thriller",
                    Cancelled = true
                }, new Movies
                {
                    Id = 11,
                    Name = "Once Upon a Time in China II (Wong Fei-hung Ji Yi: Naam yi dong ji keung)",
                    Gender = "Action|Romance",
                    Cancelled = false
                }, new Movies
                {
                    Id = 12,
                    Name = "Topper",
                    Gender = "Comedy|Fantasy|Romance",
                    Cancelled = true
                }, new Movies
                {
                    Id = 13,
                    Name = "Spy Hard",
                    Gender = "Comedy",
                    Cancelled = false
                }, new Movies
                {
                    Id = 14,
                    Name = "Stand Up and Cheer!",
                    Gender = "Comedy|Musical",
                    Cancelled = false
                }, new Movies
                {
                    Id = 15,
                    Name = "Helsinki Napoli All Night Long",
                    Gender = "Comedy|Thriller",
                    Cancelled = false
                }, new Movies
                {
                    Id = 16,
                    Name = "The Pool Boys",
                    Gender = "Comedy",
                    Cancelled = true
                }, new Movies
                {
                    Id = 17,
                    Name = "Wallace & Gromit: The Wrong Trousers",
                    Gender = "Animation|Children|Comedy|Crime",
                    Cancelled = true
                }, new Movies
                {
                    Id = 18,
                    Name = "King of California",
                    Gender = "Comedy",
                    Cancelled = false
                }, new Movies
                {
                    Id = 19,
                    Name = "Thirteen Days",
                    Gender = "Drama|Thriller|War",
                    Cancelled = true
                }, new Movies
                {
                    Id = 20,
                    Name = "Hostel: Part III ",
                    Gender = "Horror|Thriller",
                    Cancelled = false
                }, new Movies
                {
                    Id = 21,
                    Name = "The Rise",
                    Gender = "Crime|Drama|Thriller",
                    Cancelled = false
                }, new Movies
                {
                    Id = 22,
                    Name = "Wife! Be Like a Rose! (Tsuma yo bara no yo ni)",
                    Gender = "Drama",
                    Cancelled = true
                }, new Movies
                {
                    Id = 23,
                    Name = "Horse Rebellion, The (Pulakapina)",
                    Gender = "Drama",
                    Cancelled = true
                }, new Movies
                {
                    Id = 24,
                    Name = "Curse of the Pink Panther",
                    Gender = "Comedy|Crime|Mystery",
                    Cancelled = true
                }, new Movies
                {
                    Id = 25,
                    Name = "Passionate Friends, The (a.k.a. One Woman's Story)",
                    Gender = "Drama",
                    Cancelled = true
                }, new Movies
                {
                    Id = 26,
                    Name = "Doctor Zhivago",
                    Gender = "Drama|Romance|War",
                    Cancelled = false
                }, new Movies
                {
                    Id = 27,
                    Name = "Elementary Particles, The (Elementarteilchen)",
                    Gender = "Drama|Romance",
                    Cancelled = false
                }, new Movies
                {
                    Id = 28,
                    Name = "Buccaneer, The",
                    Gender = "Adventure",
                    Cancelled = false
                }, new Movies
                {
                    Id = 29,
                    Name = "Sudden Impact",
                    Gender = "Crime|Thriller",
                    Cancelled = true
                }, new Movies
                {
                    Id = 30,
                    Name = "Kill Me Later",
                    Gender = "Romance|Thriller",
                    Cancelled = true
                }, new Movies
                {
                    Id = 31,
                    Name = "King of Fighters, The",
                    Gender = "Action|Sci-Fi",
                    Cancelled = true
                }, new Movies
                {
                    Id = 32,
                    Name = "Woman, a Gun and a Noodle Shop, A (San qiang pai an jing qi)",
                    Gender = "Comedy|Drama",
                    Cancelled = false
                }, new Movies
                {
                    Id = 33,
                    Name = "Best of the Best 2",
                    Gender = "Action",
                    Cancelled = false
                }, new Movies
                {
                    Id = 34,
                    Name = "Doom",
                    Gender = "Action|Horror|Sci-Fi",
                    Cancelled = true
                }, new Movies
                {
                    Id = 35,
                    Name = "Brenda Starr",
                    Gender = "Adventure",
                    Cancelled = false
                }, new Movies
                {
                    Id = 36,
                    Name = "Private Eyes, The",
                    Gender = "Comedy|Mystery",
                    Cancelled = false
                }, new Movies
                {
                    Id = 37,
                    Name = "Care Bears Movie, The",
                    Gender = "Animation|Children|Fantasy",
                    Cancelled = false
                }, new Movies
                {
                    Id = 38,
                    Name = "First Wives Club, The",
                    Gender = "Comedy",
                    Cancelled = true
                }, new Movies
                {
                    Id = 39,
                    Name = "Hot Saturday",
                    Gender = "Drama",
                    Cancelled = false
                }, new Movies
                {
                    Id = 40,
                    Name = "Ivan's Childhood (a.k.a. My Name is Ivan) (Ivanovo detstvo)",
                    Gender = "Drama|War",
                    Cancelled = false
                }, new Movies
                {
                    Id = 41,
                    Name = "Ca$h",
                    Gender = "Action|Comedy|Crime|Thriller",
                    Cancelled = true
                }, new Movies
                {
                    Id = 42,
                    Name = "Insect Woman, The (Nippon konchûki)",
                    Gender = "Drama",
                    Cancelled = false
                }, new Movies
                {
                    Id = 43,
                    Name = "Promised Life, The (Vie promise, La)",
                    Gender = "Drama",
                    Cancelled = true
                }, new Movies
                {
                    Id = 44,
                    Name = "Journey to the West: Conquering the Demons (Daai wa sai you chi Chui mo chun kei)",
                    Gender = "Adventure|Comedy|Fantasy|Romance|IMAX",
                    Cancelled = true
                }, new Movies
                {
                    Id = 45,
                    Name = "Sophie's World (Sofies verden)",
                    Gender = "Adventure|Drama|Fantasy",
                    Cancelled = true
                }, new Movies
                {
                    Id = 46,
                    Name = "ABCs of Death, The",
                    Gender = "Horror",
                    Cancelled = true
                }, new Movies
                {
                    Id = 47,
                    Name = "Frozen Dead, The",
                    Gender = "Horror|Sci-Fi",
                    Cancelled = false
                }, new Movies
                {
                    Id = 48,
                    Name = "Linda Linda Linda",
                    Gender = "Comedy|Drama",
                    Cancelled = false
                }, new Movies
                {
                    Id = 49,
                    Name = "Garage, The",
                    Gender = "Comedy",
                    Cancelled = true
                }, new Movies
                {
                    Id = 50,
                    Name = "Owl and the Pussycat, The",
                    Gender = "Comedy",
                    Cancelled = true
                }, new Movies
                {
                    Id = 51,
                    Name = "Carnosaur",
                    Gender = "Horror|Sci-Fi",
                    Cancelled = true
                }, new Movies
                {
                    Id = 52,
                    Name = "Turks & Caicos",
                    Gender = "Drama|Mystery|Thriller",
                    Cancelled = false
                }, new Movies
                {
                    Id = 53,
                    Name = "Iran Is Not the Problem",
                    Gender = "Documentary",
                    Cancelled = false
                }, new Movies
                {
                    Id = 54,
                    Name = "Stomp the Yard",
                    Gender = "Drama|Musical",
                    Cancelled = true
                }, new Movies
                {
                    Id = 55,
                    Name = "Housebound",
                    Gender = "Comedy|Horror|Thriller",
                    Cancelled = true
                }, new Movies
                {
                    Id = 56,
                    Name = "Georg",
                    Gender = "Drama|Musical",
                    Cancelled = true
                }, new Movies
                {
                    Id = 57,
                    Name = "Tomorrow, When the War Began",
                    Gender = "Action|Adventure|Drama",
                    Cancelled = true
                }, new Movies
                {
                    Id = 58,
                    Name = "Human Capital (Il capitale umano)",
                    Gender = "Drama",
                    Cancelled = false
                }, new Movies
                {
                    Id = 59,
                    Name = "Nordkraft",
                    Gender = "Crime|Drama|Romance",
                    Cancelled = false
                }, new Movies
                {
                    Id = 60,
                    Name = "Spread",
                    Gender = "Drama|Romance",
                    Cancelled = true
                }, new Movies
                {
                    Id = 61,
                    Name = "Skin Deep",
                    Gender = "Comedy",
                    Cancelled = false
                }, new Movies
                {
                    Id = 62,
                    Name = "Postman, The (Postino, Il)",
                    Gender = "Comedy|Drama|Romance",
                    Cancelled = false
                }, new Movies
                {
                    Id = 63,
                    Name = "From the Clouds to the Resistance (Dalla nube alla resistenza)",
                    Gender = "Drama",
                    Cancelled = false
                }, new Movies
                {
                    Id = 64,
                    Name = "Promise, The (Wu ji)",
                    Gender = "Action|Drama|Fantasy",
                    Cancelled = false
                }, new Movies
                {
                    Id = 65,
                    Name = "Confessions of a Gangsta",
                    Gender = "Action",
                    Cancelled = true
                }, new Movies
                {
                    Id = 66,
                    Name = "Teen Beach Movie",
                    Gender = "Children|Musical",
                    Cancelled = true
                }, new Movies
                {
                    Id = 67,
                    Name = "Point of No Return",
                    Gender = "Action|Thriller",
                    Cancelled = true
                }, new Movies
                {
                    Id = 68,
                    Name = "Sam Peckinpah: Man of Iron",
                    Gender = "Documentary",
                    Cancelled = true
                }, new Movies
                {
                    Id = 69,
                    Name = "Orlando",
                    Gender = "Drama|Fantasy|Romance",
                    Cancelled = true
                }, new Movies
                {
                    Id = 70,
                    Name = "Black Coffee",
                    Gender = "Comedy|Romance",
                    Cancelled = false
                }, new Movies
                {
                    Id = 71,
                    Name = "Saints and Soldiers: Airborne Creed",
                    Gender = "Action|Drama|War",
                    Cancelled = false
                }, new Movies
                {
                    Id = 72,
                    Name = "End of St. Petersburg, The (Konets Sankt-Peterburga)",
                    Gender = "Drama",
                    Cancelled = false
                }, new Movies
                {
                    Id = 73,
                    Name = "Johnny Handsome",
                    Gender = "Crime|Drama",
                    Cancelled = true
                }, new Movies
                {
                    Id = 74,
                    Name = "Noah's Arc Principle, The (Arche Noah Prinzip, Das)",
                    Gender = "Sci-Fi",
                    Cancelled = false
                }, new Movies
                {
                    Id = 75,
                    Name = "HealtH",
                    Gender = "Comedy",
                    Cancelled = false
                }, new Movies
                {
                    Id = 76,
                    Name = "Love and Basketball",
                    Gender = "Drama|Romance",
                    Cancelled = false
                }, new Movies
                {
                    Id = 77,
                    Name = "All Together",
                    Gender = "Comedy|Drama",
                    Cancelled = true
                }, new Movies
                {
                    Id = 78,
                    Name = "Electra Glide in Blue",
                    Gender = "Action|Crime",
                    Cancelled = false
                }, new Movies
                {
                    Id = 79,
                    Name = "Adventures of Power",
                    Gender = "Comedy|Musical",
                    Cancelled = false
                }, new Movies
                {
                    Id = 80,
                    Name = "Oz the Great and Powerful",
                    Gender = "Action|Adventure|Fantasy|IMAX",
                    Cancelled = true
                }, new Movies
                {
                    Id = 81,
                    Name = "Armstrong Lie, The",
                    Gender = "Documentary",
                    Cancelled = true
                }, new Movies
                {
                    Id = 82,
                    Name = "Nicholas and Alexandra",
                    Gender = "Drama|War",
                    Cancelled = false
                }, new Movies
                {
                    Id = 83,
                    Name = "Page Miss Glory",
                    Gender = "Comedy",
                    Cancelled = false
                }, new Movies
                {
                    Id = 84,
                    Name = "Manufactured Landscapes",
                    Gender = "Documentary",
                    Cancelled = false
                }, new Movies
                {
                    Id = 85,
                    Name = "English Surgeon, The",
                    Gender = "Documentary",
                    Cancelled = true
                }, new Movies
                {
                    Id = 86,
                    Name = "Magic Sword, The",
                    Gender = "Drama|Fantasy",
                    Cancelled = true
                }, new Movies
                {
                    Id = 87,
                    Name = "Color of Friendship, The",
                    Gender = "Comedy|Drama",
                    Cancelled = true
                }, new Movies
                {
                    Id = 88,
                    Name = "Hotel New Hampshire, The",
                    Gender = "Drama",
                    Cancelled = false
                }, new Movies
                {
                    Id = 89,
                    Name = "Yolki 2",
                    Gender = "Comedy",
                    Cancelled = true
                }, new Movies
                {
                    Id = 90,
                    Name = "Mulholland Drive",
                    Gender = "Crime|Drama|Film-Noir|Mystery|Thriller",
                    Cancelled = false
                }, new Movies
                {
                    Id = 91,
                    Name = "Zatoichi's Vengeance (Zatôichi no uta ga kikoeru) (Zatôichi 13)",
                    Gender = "Action|Drama",
                    Cancelled = false
                }, new Movies
                {
                    Id = 92,
                    Name = "Louis C.K.: Live at The Comedy Store",
                    Gender = "Comedy",
                    Cancelled = true
                }, new Movies
                {
                    Id = 93,
                    Name = "Debt, The",
                    Gender = "Drama|Thriller",
                    Cancelled = false
                }, new Movies
                {
                    Id = 94,
                    Name = "The Puzzle",
                    Gender = "Drama",
                    Cancelled = true
                }, new Movies
                {
                    Id = 95,
                    Name = "McCullin",
                    Gender = "Documentary",
                    Cancelled = false
                }, new Movies
                {
                    Id = 96,
                    Name = "Istanbul",
                    Gender = "(no genres listed)",
                    Cancelled = true
                }, new Movies
                {
                    Id = 97,
                    Name = "36th Chamber of Shaolin, The (Shao Lin san shi liu fang) (Master Killer)",
                    Gender = "Action|Adventure",
                    Cancelled = false
                }, new Movies
                {
                    Id = 98,
                    Name = "Daddy and Them",
                    Gender = "Comedy|Drama",
                    Cancelled = true
                }, new Movies
                {
                    Id = 99,
                    Name = "Prowler, The (a.k.a. Rosemary's Killer) (a.k.a. The Graduation)",
                    Gender = "Horror",
                    Cancelled = false
                }, new Movies
                {
                    Id = 100,
                    Name = "Warped Ones, The (Kyonetsu no kisetsu)",
                    Gender = "Drama",
                    Cancelled = true
                }

                );
        }
	}
}

