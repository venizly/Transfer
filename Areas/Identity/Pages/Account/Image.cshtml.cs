using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectFinal1.Areas.Identity.Data;
using ProjectFinal1.Models;
using System.ComponentModel.DataAnnotations;

namespace ProjectFinal1.Areas.Identity.Pages.Account
{
    public class ImageModel : PageModel
    {
        private readonly SignInManager<AppilcationUser> _signInManager;
        private readonly UserManager<AppilcationUser> _userInManager;
        private readonly ProjectFinal1.Data.ProjectDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ImageModel(SignInManager<AppilcationUser> signInManager, ProjectFinal1.Data.ProjectDbContext context,
            UserManager<AppilcationUser> userInManager, IWebHostEnvironment hostEnvironment
            )
        {
            _signInManager = signInManager;
            _userInManager = userInManager;
            _hostEnvironment = hostEnvironment;
            _context = context;
        }
        [TempData]
        public string? Username { get; set; }
        //[BindProperty]
        //public InputModel? Input { get; set; }
        [TempData]
        public string StatusMessage { get; set; }
        [TempData]
        public string FileName1 { get; set; }
        [TempData]
        public string FileName2 { get; set; }
        //public class InputModel
        //{
        //    [Display(Name = "Transcode")]
        //    public string Transcode { get; set; }

        //    public string Status { get; set; }
        //}
        public async Task<IActionResult> OnGet()
        {
            if (User == null)
            {
                return NotFound($"ไม่สามารถโหลดข้อมูลของผู้ใช้ที่ไม่มี ID ได้ '{_userInManager.GetUserId(User)}'.");
            }

            var user = await _userInManager.GetUserAsync(User);
            Username = user.UserName;
            FileName1 = user.FileName;
            FileName2 = user.FileName2;
            return Page();
        }

      
 

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userInManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"ไม่สามารถโหลดข้อมูลของผู้ใช้ที่ไม่มี ID ได้ '{_userInManager.GetUserId(User)}'.");
            }
            //if (Input.Transcode != user.Transcode)
            //{
            //    user.Transcode = Input.Transcode;
            //}
            //if (Input.Status != user.Status)
            //{
            //    user.Status = Input.Status;
            //}
            if (!ModelState.IsValid)
            {
                StatusMessage = "ไฟล์รูปภาพไม่ถูกต้อง";
                return RedirectToPage();
            }
            var updateUser = _context.Users.FirstOrDefault(a => a.UserName == user.UserName);
            
            if (Request.Form.Files != null && Request.Form.Files.Count == 1)
            {
                using (var memoryStream = new MemoryStream())
                {

                    await Request.Form.Files[0].CopyToAsync(memoryStream);
                    //var id = new Random().Next(0, 1000000);
                    if (memoryStream.Length < 10495849)
                    {
                        //var file = new AppFile()
                        //{
                        //    Transcode = Input.Transcode,
                        //    FileName = FileUpload.FormFile.FileName,
                        //    Content = memoryStream.ToArray()
                        //};

                        updateUser.FileName = Request.Form.Files[0].FileName;
                        updateUser.FileContent = memoryStream.ToArray();

                    }
                    else
                    {
                        StatusMessage = "ขนาดไฟล์ใหญ่เกินไป";
                        ModelState.AddModelError("File", "ขนาดไฟล์ใหญ่เกินไป");
                        return RedirectToPage();
                    }



                }
            }
           


            if (Request.Form.Files != null && Request.Form.Files.Count == 2)
            {
                using (var memoryStream = new MemoryStream())
                {

                    await Request.Form.Files[1].CopyToAsync(memoryStream);
                    //var id = new Random().Next(0, 1000000);
                    if (memoryStream.Length < 10495849)
                    {
                       
                        updateUser.FileName2 = Request.Form.Files[1].FileName;
                        updateUser.FileContent2 = memoryStream.ToArray();

                    }
                    else
                    {
                        StatusMessage = "ขนาดไฟล์ใหญ่เกินไป";
                        ModelState.AddModelError("File", "ขนาดไฟล์ใหญ่เกินไป");
                        return RedirectToPage();
                    }



                }
            }
             

            _context.Entry(updateUser).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        //    StatusMessage = "คุณได้ส่งไฟล์รูปภาพสำเร็จ";
            return RedirectToPage();
        }
    }
}
