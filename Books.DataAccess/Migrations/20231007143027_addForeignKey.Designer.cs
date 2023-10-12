﻿// <auto-generated />
using Books.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Books.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231007143027_addForeignKey")]
    partial class addForeignKey
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-rc.1.23419.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Books.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Self Help"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Finance"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Autobiography"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "Fantasy"
                        });
                });

            modelBuilder.Entity("Books.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ListPrice")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Price100")
                        .HasColumnType("float");

                    b.Property<double>("Price50")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Shwetabh Gangwar",
                            CategoryId = 1,
                            Description = "Insanely Practical Ideas To Free Your Mind From All Bullshit ",
                            ISBN = "SWD9999001",
                            ListPrice = 99.0,
                            Price = 90.0,
                            Price100 = 80.0,
                            Price50 = 85.0,
                            Title = "The Rudest Book Ever"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Napoleon Hill",
                            CategoryId = 2,
                            Description = "The book is considered a classic in the personal development genre and has been widely influential in shaping the way people think about success and wealth. ",
                            ISBN = "CAW777777701",
                            ListPrice = 40.0,
                            Price = 30.0,
                            Price100 = 20.0,
                            Price50 = 25.0,
                            Title = "Think and Grow Rich"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Joseph Murphy",
                            CategoryId = 1,
                            Description = "Dr. Joseph Murphy explains that life events are actually the result of the workings of your conscious and subconscious minds. ",
                            ISBN = "RITO5555501",
                            ListPrice = 55.0,
                            Price = 50.0,
                            Price100 = 35.0,
                            Price50 = 40.0,
                            Title = "The Power of your subconscious mind"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Eckhart Tolle",
                            CategoryId = 1,
                            Description = "Eckhart Tolle takes you on a journey that explores presence, thinking, spirituality, and how to reduce pain in your life. ",
                            ISBN = "WS3333333301",
                            ListPrice = 70.0,
                            Price = 65.0,
                            Price100 = 55.0,
                            Price50 = 60.0,
                            Title = "The Power of Now"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Paulo Coelho",
                            CategoryId = 1,
                            Description = "The Alchemist tells the story of a young man who beat fear to follow his Personal Legend and how you can do the same thing too. ",
                            ISBN = "SOTJ1111111101",
                            ListPrice = 30.0,
                            Price = 27.0,
                            Price100 = 20.0,
                            Price50 = 25.0,
                            Title = "The Alchemist"
                        },
                        new
                        {
                            Id = 6,
                            Author = "A. P. J. Abdul Kalam",
                            CategoryId = 3,
                            Description = "Wings of Fire, is the autobiography of the Missile Man of India and President of India, Dr. A. P. J. Abdul Kalam. It was written by him and Arun Tiwari. ",
                            ISBN = "FOT000035411",
                            ListPrice = 35.0,
                            Price = 33.0,
                            Price100 = 30.0,
                            Price50 = 32.0,
                            Title = "Wings of Fire"
                        },
                        new
                        {
                            Id = 7,
                            Author = "George R. R. Martin",
                            CategoryId = 4,
                            Description = "A Game of Thrones is the first novel in A Song of Ice and Fire, a series of fantasy novels by American author George R. R. Martin. ",
                            ISBN = "SEOT00006541",
                            ListPrice = 25.0,
                            Price = 23.0,
                            Price100 = 20.0,
                            Price50 = 22.0,
                            Title = "A Game of Thrones"
                        },
                        new
                        {
                            Id = 8,
                            Author = "Robert Kiyosaki",
                            CategoryId = 2,
                            Description = "Rich Dad Poor Dad is about Robert Kiyosaki and his two dads—his real father (poor dad) and the father of his best friend (rich dad) ",
                            ISBN = "ZDV000300235",
                            ListPrice = 55.0,
                            Price = 43.0,
                            Price100 = 40.0,
                            Price50 = 42.0,
                            Title = "Rich Dad Poor Dad"
                        });
                });

            modelBuilder.Entity("Books.Models.Product", b =>
                {
                    b.HasOne("Books.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
