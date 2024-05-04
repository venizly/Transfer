using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectFinal1.Areas.Identity.Data;
using ProjectFinal1.Models;
using System.ComponentModel.DataAnnotations;
using System.IO;

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
        [TempData]
        public string StatusMessage { get; set; }
        [TempData]
        public string FileName1 { get; set; }
        [TempData]
        public string FileName2 { get; set; }
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
            if (!ModelState.IsValid)
            {
                StatusMessage = "ไฟล์รูปภาพไม่ถูกต้อง";
                return RedirectToPage();
            }
            var updateUser = _context.Users.FirstOrDefault(a => a.UserName == user.UserName);
            if (Request.Form.Files != null)
            {
                foreach (var item in Request.Form.Files)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        await item.CopyToAsync(memoryStream);
                        if (item.Name == "file1")
                        {

                            updateUser.FileName = item.FileName;
                            updateUser.FileContent = memoryStream.ToArray();
                        }
                        if (item.Name == "file2")
                        {
                            updateUser.FileName2 = item.FileName;
                            updateUser.FileContent2 = memoryStream.ToArray();
                        }
                    }




                }
                _context.Entry(updateUser).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                StatusMessage = "ขนาดไฟล์ใหญ่เกินไป";
            }
       
            //    StatusMessage = "คุณได้ส่งไฟล์รูปภาพสำเร็จ";
            return RedirectToPage();
        }
    }
}
