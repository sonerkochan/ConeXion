using ConeXion.Core.Contracts;
using ConeXion.Core.Services;
using ConeXion.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static ConeXion.Areas.Member.Constants.MemberConstants;

namespace ConeXion.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IPostService postService;

        public HomeController(ILogger<HomeController> logger,
           IPostService _postService)
        {
            _logger = logger;
            postService = _postService;
        }

        public IActionResult Index()
        {
            if (User.IsInRole(MemberRoleName))
            {
                return RedirectToAction("Home");
            }

            return View();
        }


        public async Task<IActionResult> Home()
        {
            var model = await postService.GetAllAsync();

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}