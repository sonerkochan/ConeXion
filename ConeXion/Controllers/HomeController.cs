using ConeXion.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static ConeXion.Areas.Member.Constants.MemberConstants;

namespace ConeXion.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (User.IsInRole(MemberRoleName))
            {
                return RedirectToAction("Index", MemberRoleName, new { area = MemberAreaName });
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}