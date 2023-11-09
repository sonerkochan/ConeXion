using ConeXion.Core.Contracts;
using ConeXion.Core.Models.Like;
using ConeXion.Core.Models.Post;
using ConeXion.Infrastructure.Data;
using ConeXion.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ConeXion.Controllers
{
    public class PostController : Controller
    {

        private readonly ApplicationDbContext context;
        private readonly IPostService postService;
        private readonly IUserService userService;
        private readonly UserManager<User> userManager;

        public PostController(
           IPostService _postService,
           ApplicationDbContext _context,
           IUserService _userService,
           UserManager<User> _userManager)
        {
            postService = _postService;
            context = _context;
            userService = _userService;
            userManager = _userManager;
        }
        /// <summary>
        /// Method to add a new post to the website.
        /// </summary>
        /// <returns>A form to fill with data of the new post.</returns>
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var model = new AddPostViewModel()
            {
                UserID = userId
            };

            return View(model);
        }

        /// <summary>
        /// Validates the data of the newly added post before adding it to the database.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> Add(AddPostViewModel addPostViewModel)
        {
            if (!ModelState.IsValid)
            {
                Console.WriteLine("NOT VALID");
                return View(addPostViewModel);
            }

            try
            {
                Console.WriteLine("TRY");

                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                addPostViewModel.UserID = userId;

                //Is the code above okay? I think there's another way of doing it but \("/)/

                await postService.AddPostAsync(addPostViewModel);

                return RedirectToAction("Index", "Home");
            }
            catch (Exception)
            {
                Console.WriteLine("CATCH");
                ModelState.AddModelError("", "Something went wrong");

                return View(addPostViewModel);
            }
        }


        [HttpPost]
        public async Task<IActionResult> Like(int postId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var newLikeViewModel = new NewLikeViewModel()
            {
                UserID = userId,
                PostID = postId
            };

            if (!ModelState.IsValid)
            {
                return View(newLikeViewModel);
            }

            try
            {

                await postService.LikePostAsync(newLikeViewModel);

                return RedirectToAction("Index", "Home");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Something went wrong");

                return View(newLikeViewModel);
            }
        }

    }
}
