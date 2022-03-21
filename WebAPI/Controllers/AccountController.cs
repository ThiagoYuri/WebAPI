using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    public class AccountController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
