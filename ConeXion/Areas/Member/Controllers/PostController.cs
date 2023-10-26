using ConeXion.Core.Contracts;
using ConeXion.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace ConeXion.Areas.Member.Controllers
{
    public class PostController : Controller
    {

        private readonly IPostService postService;

        public PostController(
           IPostService _postService)
        {
            postService = _postService;
        }

        public async Task<IActionResult> All()
        {
            var model = await postService.GetAllAsync();

            return View(model);
        }
    }
}
