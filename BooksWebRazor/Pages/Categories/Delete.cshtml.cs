using BooksWebRazor.Data;
using BooksWebRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BooksWebRazor.Pages.Categories
{
    [BindProperties]
    public class DeleteModel(ApplicationDbContext db) : PageModel
    {
        private readonly ApplicationDbContext _db = db;
        public Category Category { get; set; }

        public void OnGet(int? id)
        {
            if (id != null && id != 0)
            {
                Category = _db.Categories.Find(id);
            }
        }
        public IActionResult OnPost()
        {
            Category? obj = _db.Categories.Find(Category.Id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Categories.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Category deleted successfully";
            return RedirectToPage("Index");

        }
    }
}
