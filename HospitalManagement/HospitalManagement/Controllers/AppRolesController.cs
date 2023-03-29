using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.Controllers
{
    public class AppRolesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
