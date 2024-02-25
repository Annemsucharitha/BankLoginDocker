using Microsoft.AspNetCore.Mvc;

namespace BankLoginPageUsingDocker.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View("Dashboard");
        }
    }
}
