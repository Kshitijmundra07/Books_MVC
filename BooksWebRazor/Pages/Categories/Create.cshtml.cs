using BooksWebRazor.Data;
using BooksWebRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BooksWebRazor.Pages.Categories
{
    [BindProperties]
    public class CreateModel(ApplicationDbContext db) : PageModel
    {
        private readonly ApplicationDbContext _db = db;
        public Category Category { get; set; }

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            _db.Categories.Add(Category);
            _db.SaveChanges();
            TempData["success"] = "Category created successfully";
            return RedirectToPage("Index");
        }
    }
}

