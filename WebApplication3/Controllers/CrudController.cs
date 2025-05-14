using Microsoft.AspNetCore.Mvc;

namespace KindHeartCharity.Controllers
{
    public class CrudController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
