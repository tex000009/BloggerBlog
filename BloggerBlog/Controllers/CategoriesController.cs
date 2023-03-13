using BloggerBlog.Data;
using Microsoft.AspNetCore.Mvc;

namespace BloggerBlog.Controllers
{
    public class CategoriesController : Controller
    {
         private readonly ApplicationDbContext _context;

        public CategoriesController (ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
