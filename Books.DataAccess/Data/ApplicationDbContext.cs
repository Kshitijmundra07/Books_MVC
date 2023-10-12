using Books.Models;
using Microsoft.EntityFrameworkCore;

namespace Books.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Self Help", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Finance", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Autobiography", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Fantasy", DisplayOrder = 4 }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "The Rudest Book Ever",
                    Author = "Shwetabh Gangwar",
                    Description = "Insanely Practical Ideas To Free Your Mind From All Bullshit ",
                    ISBN = "SWD9999001",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 1,
                    ImageUrl=""
                },
                new Product
                {
                    Id = 2,
                    Title = "Think and Grow Rich",
                    Author = "Napoleon Hill",
                    Description = "The book is considered a classic in the personal development genre and has been widely influential in shaping the way people think about success and wealth. ",
                    ISBN = "CAW777777701",
                    ListPrice = 40,
                    Price = 30,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 2,
                    ImageUrl = ""

                },
                new Product
                {
                    Id = 3,
                    Title = "The Power of your subconscious mind",
                    Author = "Joseph Murphy",
                    Description = "Dr. Joseph Murphy explains that life events are actually the result of the workings of your conscious and subconscious minds. ",
                    ISBN = "RITO5555501",
                    ListPrice = 55,
                    Price = 50,
                    Price50 = 40,
                    Price100 = 35,
                    CategoryId = 1,
                    ImageUrl = ""

                },
                new Product
                {
                    Id = 4,
                    Title = "The Power of Now",
                    Author = "Eckhart Tolle",
                    Description = "Eckhart Tolle takes you on a journey that explores presence, thinking, spirituality, and how to reduce pain in your life. ",
                    ISBN = "WS3333333301",
                    ListPrice = 70,
                    Price = 65,
                    Price50 = 60,
                    Price100 = 55,
                    CategoryId = 1,
                    ImageUrl = ""

                },
                new Product
                {
                    Id = 5,
                    Title = "The Alchemist",
                    Author = "Paulo Coelho",
                    Description = "The Alchemist tells the story of a young man who beat fear to follow his Personal Legend and how you can do the same thing too. ",
                    ISBN = "SOTJ1111111101",
                    ListPrice = 30,
                    Price = 27,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 1,
                    ImageUrl = ""

                },
                new Product
                {
                    Id = 6,
                    Title = "Wings of Fire",
                    Author = "A. P. J. Abdul Kalam",
                    Description = "Wings of Fire, is the autobiography of the Missile Man of India and President of India, Dr. A. P. J. Abdul Kalam. It was written by him and Arun Tiwari. ",
                    ISBN = "FOT000035411",
                    ListPrice = 35,
                    Price = 33,
                    Price50 = 32,
                    Price100 = 30,
                    CategoryId = 3,
                    ImageUrl = ""

                },

                  new Product
                  {
                      Id = 7,
                      Title = "A Game of Thrones",
                      Author = "George R. R. Martin",
                      Description = "A Game of Thrones is the first novel in A Song of Ice and Fire, a series of fantasy novels by American author George R. R. Martin. ",
                      ISBN = "SEOT00006541",
                      ListPrice = 25,
                      Price = 23,
                      Price50 = 22,
                      Price100 = 20,
                      CategoryId = 4,
                      ImageUrl = ""

                  },

                  new Product
                  {
                      Id = 8,
                      Title = "Rich Dad Poor Dad",
                      Author = "Robert Kiyosaki",
                      Description = "Rich Dad Poor Dad is about Robert Kiyosaki and his two dads—his real father (poor dad) and the father of his best friend (rich dad) ",
                      ISBN = "ZDV000300235",
                      ListPrice = 55,
                      Price = 43,
                      Price50 = 42,
                      Price100 = 40,
                      CategoryId = 2,
                      ImageUrl = ""

                  }
                );
        }
    }
}

