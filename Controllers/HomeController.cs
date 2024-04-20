using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectFinal1.Areas.Identity.Data;
using ProjectFinal1.Data;
using ProjectFinal1.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using System.Reflection.PortableExecutable;

namespace ProjectFinal1.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<AppilcationUser> _userManager;
        private readonly SignInManager<AppilcationUser> _signManager;
        private readonly ProjectDbContext _db;

        public HomeController(ProjectDbContext Db, UserManager<AppilcationUser> userManager, SignInManager<AppilcationUser> signManager)
        {
            _db = Db;
            this._userManager = userManager;
            this._signManager = signManager;
        }
        public IActionResult Index()
        {
            //ViewData["User"] = _userManager.GetUserName(this.User);
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult FullCourseCs()
        {
            IEnumerable<V_CourseCss> tra = _db.V_CourseCss;
            return View(tra);
        }

        ///////////////////////////////////////////////////////////////////////

        public IActionResult CourseTra()
        {
            IEnumerable<TraCourse> tra = _db.TraCourse;
            return View(tra);
        }
        public IActionResult DetailSubTra(int Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var obj = _db.V_CourseTra.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        public IActionResult DetailCourseTra(int Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            var obj = _db.V_CourseTra.Where(a => a.Codecourse == Id).ToList();
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        public IActionResult FullCourseTra(int Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var obj = _db.V_CourseTra.Where(a => a.Codecourse == Id).ToList();
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        ///////////////////////////////////////////////////////////////////////

        public IActionResult TransResult()
        {
            IEnumerable<V_User_Tranfer_Course> Re = _db.V_User_Tranfer_Courses.Where(a => a.UserName == User.Identity.Name && !a.IsHide && a.GradeTra != null);
            return View(Re);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}