using ConeXion.Core.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ConeXion.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IPostService postService;

        public ProfileController(IPostService _postService)
        {
            postService = _postService;
        }
        public async Task<IActionResult> Me()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var model = await postService.GetUsersPostsAsync(userId);

            return View(model);
        }

    }
}
