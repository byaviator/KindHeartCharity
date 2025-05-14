using KindHeartCharity.Services;
using Microsoft.AspNetCore.Mvc;

namespace KindHeartCharity.Controllers
{
    public class HomeController : Controller
    {
        private readonly StaffService _staffService;
        public HomeController()
        {
            _staffService = new StaffService();
        }
        public IActionResult Index()
        {
            var getAllStaff = _staffService.GetAllStaff();
            return View(getAllStaff);
        }
    }
}
