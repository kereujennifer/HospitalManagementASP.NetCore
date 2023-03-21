using Microsoft.AspNetCore.Mvc;

namespace CrudOperations.Controllers
{
    public class AdministrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
