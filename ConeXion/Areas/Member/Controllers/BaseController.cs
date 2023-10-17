using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using static ConeXion.Areas.Member.Constants.MemberConstants;

namespace ConeXion.Areas.Member.Controllers
{
    public class BaseController : Controller
    {
        /// <summary>
        /// Base controller class that all other controllers in Admin area inherit in order to lock authorization.
        /// </summary>
        [Area(MemberAreaName)]
        [Route("/Admin/[controller]/[Action]/{id?}")]
        [Authorize(Roles = MemberRoleName)]
        public IActionResult Index()
        {
            return View();
        }
    }
}
