using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectFinal1.Areas.Identity.Data;
using ProjectFinal1.Data;
using ProjectFinal1.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;

namespace ProjectFinal1.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<AppilcationUser> _userManager;
        private readonly SignInManager<AppilcationUser> _signManager;
        private readonly ProjectDbContext _db;

        public AdminController(ProjectDbContext Db, UserManager<AppilcationUser> userManager, SignInManager<AppilcationUser> signManager)
        {
            _db = Db;
            this._userManager = userManager;
            this._signManager = signManager;
        }
        public IActionResult TableData()
        {
            IEnumerable<DataUser> allTransfer = _db.DataUsers;
            return View(allTransfer);
        }
        //public IActionResult Detailuser(string Id)
        //{
        //    if (Id == null)
        //    {
        //        return NotFound();
        //    }
        //    var obj = _db.V_SubCsTra.Where(a => a.Transcode == Id).ToList();
        //    if (obj == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(obj);
        //}
        public IActionResult DeleteUser(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            //ค้นหาข้อมูล
            var obj = _db.DataUsers.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.DataUsers.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("TableData");
        }
        public IActionResult DeleteUsers(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            //ค้นหาข้อมูล
            var obj = _db.TableTransfer.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.TableTransfer.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Detailuser");
        }
        public IActionResult ViewImage()
        {
            //ดึงรูปออกได้ ที่อยากได้คือให้มันอยู่ตารางเดียวกันหรือใช้ ViewTable
            IEnumerable<AppFile> allTransfer = _db.File;
            return View(allTransfer);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////

        public IActionResult CourseCsAdmin()
        {
            IEnumerable<CsCourse> allTransfer = _db.CsCourse;
            return View(allTransfer);
        }
        public IActionResult AddCourseCs()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCourseCs(CsCourse obje)
        {
            if (ModelState.IsValid)
            {
                _db.CsCourse.Add(obje);
                _db.SaveChanges();
                return RedirectToAction("CourseCsAdmin");
            }
            return View(obje);
        }
        public IActionResult DeleteCourseCs(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            //ต้นหาข้อมูล
            var obje = _db.CsCourse.Find(id);
            if (obje == null)
            {
                return NotFound();
            }
            _db.CsCourse.Remove(obje);
            _db.SaveChanges();
            return RedirectToAction("CourseCsAdmin");
        }
        public IActionResult CourseTraAdmin()
        {
            IEnumerable<TraCourse> allTransfer = _db.TraCourse;
            return View(allTransfer);
        }
        public IActionResult AddCourseTra()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCourseTra(TraCourse obje)
        {
            if (ModelState.IsValid)
            {
                _db.TraCourse.Add(obje);
                _db.SaveChanges();
                return RedirectToAction("CourseTraAdmin");
            }
            return View(obje);
        }
        public IActionResult DeleteCourseTra(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            //ต้นหาข้อมูล
            var obje = _db.TraCourse.Find(id);
            if (obje == null)
            {
                return NotFound();
            }
            _db.TraCourse.Remove(obje);
            _db.SaveChanges();
            return RedirectToAction("CourseTraAdmin");
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
        public IActionResult PairCourse()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PairCourse(TransferCourse obje)
        {
            if (ModelState.IsValid)
            {
                _db.TransferCourse.Add(obje);
                _db.SaveChanges();
                return RedirectToAction("TransferCourse");
            }
            return View(obje);
        }
        public IActionResult DeleteCourse(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            //ต้นหาข้อมูล
            var obj = _db.TransferCourse.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.TransferCourse.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("TransferCourse", "Admin");
        }

        public IActionResult StudyResult(string id)
        {
            var user_tranfer_course = _db.V_User_Tranfer_Courses.Where(x => x.Id == id).ToList();
            ViewBag.id = id;
            //IEnumerable<TableTransfer> allTransfer = _db.TableTransfer;
            return View(user_tranfer_course);
        }
        [HttpPost]
        public IActionResult StudyResult(string id, List<V_User_Tranfer_Course> saveData)
        {
            if (saveData != null && saveData.Any())
            {
                int lastId = _db.TableTransfer.Any() ? _db.TableTransfer.Max(a => a.TransReCode) : 0;
                foreach (var item in saveData)
                {


                    var tableTransfer = _db.TableTransfer.FirstOrDefault(x => x.TransReCode == item.TransReCode);
                    if (tableTransfer != null)
                    {
                        tableTransfer.GradeTra = item.GradeTra;
                        _db.Entry(tableTransfer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    }
                    else
                    {
                        lastId++;
                        tableTransfer = new TableTransfer() { TransReCode = lastId };
                        tableTransfer.GradeTra = item.GradeTra;
                        tableTransfer.CodeSubtran = item.CodeSubtrans.Value;
                        tableTransfer.UserId = id;

                        _db.TableTransfer.Add(tableTransfer);
                    }
                    tableTransfer.IsHide = item.IsHide;

                }

                _db.SaveChanges();
            }
            var user_tranfer_course = _db.V_User_Tranfer_Courses.Where(x => x.Id == id).ToList();
            ViewBag.id = id;
            return View(user_tranfer_course); ;
        }

        public IActionResult AddSubCs()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddSubCs(CsCourseStruc obje)
        {
            if (ModelState.IsValid)
            {
                _db.CsCourseStruc.Add(obje);
                _db.SaveChanges();
                return RedirectToAction("AddSubCs");
            }
            return View(obje);
        }

        public IActionResult PairSub()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PairSub(TransferSub obje)
        {
            if (ModelState.IsValid)
            {
                _db.TransferSub.Add(obje);
                _db.SaveChanges();
                return RedirectToAction("PairSub");
            }
            return View(obje);
        }
        //public IActionResult EditCourse(int id)
        //{
        //    var user = _db.CsCourse.Find(id);
        //    return View(user);
        //}
        //[HttpPost]
        //public IActionResult EditCourse(CsCourse user)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _db.Update(user);
        //        _db.SaveChanges();
        //        return RedirectToAction("CourseCsAdmin", "Admin");
        //    }
        //    return View(user);
        //}

        /////////////////////////////////////////////////////////////////////////////////////////////////////

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
