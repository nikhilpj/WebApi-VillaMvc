using Microsoft.EntityFrameworkCore;
using VillaApi.Models;

namespace VillaApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }
        public DbSet<VillaItem> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VillaItem>().HasData(
                new VillaItem()
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = " Russia is reportedly poised to begin serial production of a new derivative of the Iskander-M " +
                    "tactical ballistic missile with a range of 1,000 km. Reports about the existence of a 1,000 km range " +
                    "variant of the Iskander-M first surfaced in July 2024.",
                    ImageUrl = "https://www.eurasiantimes.com/wp-content/uploads/2022/03/Iskander-M.jpg?resize=696,464",
                    Occupancy = 5,
                    Rate = 200,
                    Sqft = 550,
                    Amenity="",
                    CreatedDate= DateTime.Now

                },

                new VillaItem()
                {
                    Id = 2,
                    Name = "Diamond Villa",
                    Details = "The Iskander-M missile has a warhead that weighs between 710–800 kg. It is unlikely that the " +
                    "Iskander-1000 has a lighter warhead because a lighter warhead would not be effective against the types " +
                    "of high-value targets that the Iskander-M system is designed to attack.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/0/0d/Maiden_launch_of_Very_Short_Range_Air_Defence_System_%28VSHORADS%29_missile_%28cropped%29.jpg",
                    Occupancy = 3,
                    Rate = 200,
                    Sqft = 500,
                    Amenity="",
                    CreatedDate= DateTime.Now
                },
                 new VillaItem()
                 {
                     Id = 3,
                     Name = "Platinum Villa",
                     Details = "In a big boost to the ‘Make in India’ initiative, the Defense Research and Development" +
                     " Organisation (DRDO) demonstrated its prowess by successfully testing the Very Short Range Air " +
                     "Defense System (VSHORAD).",
                     ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/0/0d/Maiden_launch_of_Very_Short_Range_Air_Defence_System_%28VSHORADS%29_missile_%28cropped%29.jpg",
                     Occupancy = 2,
                     Rate = 500,
                     Sqft = 1000,
                     Amenity="",
                     CreatedDate= DateTime.Now
                 },

                 new VillaItem()
                 {
                     Id = 4,
                     Name = "Platinum Duper Villa",
                     Details = "VSHORADS is a fourth-generation Man Portable Air Defense System (MANPAD). In general, MANPADS are" +
                     " lightweight anti-aircraft weapons intended for rapid deployment by ground forces. They are cost-effective, " +
                     "compact, and mobile, requiring only a single operator for use.",
                     ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/0/0d/Maiden_launch_of_Very_Short_Range_Air_Defence_System_%28VSHORADS%29_missile_%28cropped%29.jpg",
                     Occupancy = 2,
                     Rate = 700,
                     Sqft = 1000,
                     Amenity="",
                     CreatedDate = DateTime.Now
                 }


            );
        }
    }
}
