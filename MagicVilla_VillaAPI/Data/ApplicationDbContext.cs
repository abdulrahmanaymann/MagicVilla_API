namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Villa> Villas { get; set; }

        public DbSet<VillaNumber> VillaNumbers { get; set; }

        public DbSet<LocalUser> localUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Villa>().HasData
            (
                new Villa
                {
                    Id = 1,
                    Name = "Luxury Villa",
                    Details = "A luxury villa with all amenities and a beautiful ocean view.",
                    Rate = 500.00,
                    Occupancy = 4,
                    Sqft = 2000,
                    ImageUrl = "https://www.pexels.com/photo/white-concrete-house-near-body-of-water-210617/",
                    Amenity = "Pool, Wi-Fi, Air Conditioning",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new Villa
                {
                    Id = 2,
                    Name = "Mountain Villa",
                    Details = "A cozy villa located in the mountains, perfect for nature lovers.",
                    Rate = 350.00,
                    Occupancy = 6,
                    Sqft = 1500,
                    ImageUrl = "https://www.pexels.com/photo/a-house-near-mountain-during-daytime-12905885/",
                    Amenity = "Fireplace, Wi-Fi, Hot Tub",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new Villa
                {
                    Id = 3,
                    Name = "Beachfront Villa",
                    Details = "A beachfront villa with direct access to the beach and stunning views.",
                    Rate = 600.00,
                    Occupancy = 5,
                    Sqft = 2500,
                    ImageUrl = "https://www.pexels.com/photo/aerial-view-of-beach-resort-2265876/",
                    Amenity = "Pool, Wi-Fi, Ocean View",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new Villa
                {
                    Id = 4,
                    Name = "Urban Villa",
                    Details = "An urban villa located in the heart of the city with luxurious amenities.",
                    Rate = 450.00,
                    Occupancy = 3,
                    Sqft = 1800,
                    ImageUrl = "https://www.pexels.com/photo/modern-urban-house-with-pool-3639902/",
                    Amenity = "Gym, Wi-Fi, Rooftop Pool",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new Villa
                {
                    Id = 5,
                    Name = "Countryside Villa",
                    Details = "A peaceful villa surrounded by nature, perfect for a quiet retreat.",
                    Rate = 300.00,
                    Occupancy = 4,
                    Sqft = 1600,
                    ImageUrl = "https://www.pexels.com/photo/house-near-a-forest-1817857/",
                    Amenity = "Garden, Fireplace, Wi-Fi",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                }
            );

            //modelBuilder.Entity<VillaNumber>().HasData
            //(
            //    new VillaNumber
            //    {
            //        VillaNo = 101,
            //        SpecialDetails = "Ocean View",
            //        CreatedDate = DateTime.Now,
            //        UpdatedDate = DateTime.Now,
            //        VillaId = 1
            //    },

            //    new VillaNumber
            //    {
            //        VillaNo = 102,
            //        SpecialDetails = "Mountain View",
            //        CreatedDate = DateTime.Now,
            //        UpdatedDate = DateTime.Now,
            //        VillaId = 2
            //    },

            //    new VillaNumber
            //    {
            //        VillaNo = 103,
            //        SpecialDetails = "Beachfront",
            //        CreatedDate = DateTime.Now,
            //        UpdatedDate = DateTime.Now,
            //        VillaId = 3
            //    },

            //    new VillaNumber
            //    {
            //        VillaNo = 104,
            //        SpecialDetails = "City View",
            //        CreatedDate = DateTime.Now,
            //        UpdatedDate = DateTime.Now,
            //        VillaId = 4
            //    },

            //    new VillaNumber
            //    {
            //        VillaNo = 105,
            //        SpecialDetails = "Garden View",
            //        CreatedDate = DateTime.Now,
            //        UpdatedDate = DateTime.Now,
            //        VillaId = 5
            //    }
            //);
        }
    }
}
