using Microsoft.AspNetCore.Mvc;

namespace ConeXion.Areas.Member.Controllers
{
    public class MemberController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
