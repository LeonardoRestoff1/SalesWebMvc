using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class VendedorController : Controller
    {

        private readonly VendedorService _vendedorService;

        public VendedorController(VendedorService vendedorService)
        {
            _vendedorService = vendedorService;
        }
        public IActionResult Index()
        {
            var list = _vendedorService.FindAll();
            return View(list);
        }

        
    }
}
