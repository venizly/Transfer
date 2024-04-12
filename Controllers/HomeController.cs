using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectFinal1.Models;
using System.Diagnostics;
using ProjectFinal1.Areas.Identity.Data;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;
using ProjectFinal1.Data;
using System.ComponentModel.DataAnnotations;

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
            _userManager = userManager;
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
        public IActionResult CourseCs()
        {
            IEnumerable<CsCourse> cs = _db.CsCourse;
            return View(cs);
        }
        public IActionResult DetailSubCs(int Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var obj = _db.V_CourseCss.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        public IActionResult DetailCourseCs(int Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var obj = _db.V_CourseCss.Where(a=>a.Codecoursecs==Id).ToList();
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
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
        public IActionResult TransferCourse()
        {
            IEnumerable<V_CourseCsTra> allTransfer = _db.V_CourseCsTra;
            return View(allTransfer);
        }
        public IActionResult TransferSub(int Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var obj = _db.V_TransferSub.Where(a => a.CodeCoursetran == Id).ToList();
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}