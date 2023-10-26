using Microsoft.AspNetCore.Mvc;
using ConeXion.Core.Contracts;
using ConeXion.Core.Models.Post;
using ConeXion.Infrastructure.Data;
using ConeXion.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;

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
