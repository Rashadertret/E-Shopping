using Microsoft.AspNetCore.Mvc;

namespace E_Shoping.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CheckOut()
        {
            return View();
        }
    }
}
