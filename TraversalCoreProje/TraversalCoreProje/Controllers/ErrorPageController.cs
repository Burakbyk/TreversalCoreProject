using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;

namespace TraversalCoreProje.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error404(int code)
        {
            return View();
        }
    }
}
