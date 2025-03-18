using Microsoft.AspNetCore.Mvc;

namespace SalesWebMvc.Controllers
{
    public class VendedorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
