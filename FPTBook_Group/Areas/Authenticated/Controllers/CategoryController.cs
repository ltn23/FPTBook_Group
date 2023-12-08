using Microsoft.AspNetCore.Mvc;

namespace FPTBook_Group.Areas.Authenticated.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
