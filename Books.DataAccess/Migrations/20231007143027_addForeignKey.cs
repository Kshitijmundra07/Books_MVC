using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Books.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Self Help" },
                    { 2, 2, "Finance" },
                    { 3, 3, "Autobiography" },
                    { 4, 4, "Fantasy" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "Shwetabh Gangwar", 1, "Insanely Practical Ideas To Free Your Mind From All Bullshit ", "SWD9999001", 99.0, 90.0, 80.0, 85.0, "The Rudest Book Ever" },
                    { 2, "Napoleon Hill", 2, "The book is considered a classic in the personal development genre and has been widely influential in shaping the way people think about success and wealth. ", "CAW777777701", 40.0, 30.0, 20.0, 25.0, "Think and Grow Rich" },
                    { 3, "Joseph Murphy", 1, "Dr. Joseph Murphy explains that life events are actually the result of the workings of your conscious and subconscious minds. ", "RITO5555501", 55.0, 50.0, 35.0, 40.0, "The Power of your subconscious mind" },
                    { 4, "Eckhart Tolle", 1, "Eckhart Tolle takes you on a journey that explores presence, thinking, spirituality, and how to reduce pain in your life. ", "WS3333333301", 70.0, 65.0, 55.0, 60.0, "The Power of Now" },
                    { 5, "Paulo Coelho", 1, "The Alchemist tells the story of a young man who beat fear to follow his Personal Legend and how you can do the same thing too. ", "SOTJ1111111101", 30.0, 27.0, 20.0, 25.0, "The Alchemist" },
                    { 6, "A. P. J. Abdul Kalam", 3, "Wings of Fire, is the autobiography of the Missile Man of India and President of India, Dr. A. P. J. Abdul Kalam. It was written by him and Arun Tiwari. ", "FOT000035411", 35.0, 33.0, 30.0, 32.0, "Wings of Fire" },
                    { 7, "George R. R. Martin", 4, "A Game of Thrones is the first novel in A Song of Ice and Fire, a series of fantasy novels by American author George R. R. Martin. ", "SEOT00006541", 25.0, 23.0, 20.0, 22.0, "A Game of Thrones" },
                    { 8, "Robert Kiyosaki", 2, "Rich Dad Poor Dad is about Robert Kiyosaki and his two dads—his real father (poor dad) and the father of his best friend (rich dad) ", "ZDV000300235", 55.0, 43.0, 40.0, 42.0, "Rich Dad Poor Dad" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
