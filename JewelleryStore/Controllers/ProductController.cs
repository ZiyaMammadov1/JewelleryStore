using Microsoft.AspNetCore.Mvc;

namespace JewelleryStore.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Detail()
        {
            return View();
        }
    }
}
