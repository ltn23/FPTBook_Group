using FPTBook_Group.Data;
using Microsoft.AspNetCore.Mvc;

namespace FPTBook_Group.Areas.Authenticated.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
