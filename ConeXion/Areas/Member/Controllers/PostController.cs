using ConeXion.Core.Contracts;
using ConeXion.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

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
    }
}
