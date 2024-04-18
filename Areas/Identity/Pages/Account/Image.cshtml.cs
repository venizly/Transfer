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
            UserManager<AppilcationUser> userInManager,IWebHostEnvironment hostEnvironment
            )
        {
            _signInManager = signInManager;
            _userInManager = userInManager;
            _hostEnvironment = hostEnvironment;
            _context = context;
        }
        public string Username { get; set; }
        [BindProperty]
        public InputModel Input { get; set; }
        [TempData]
        public string StatusMessage { get; set; }
        public class InputModel
        {
            [Display(Name = "Transcode")]
            public string Transcode { get; set; }

            public string Status { get; set; }
        }
        public async Task<IActionResult> OnGet()
        {
            var user = await _userInManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"ไม่สามารถโหลดข้อมูลของผู้ใช้ที่ไม่มี ID ได้ '{_userInManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        private async Task LoadAsync(AppilcationUser user)
        {
            var userName = await _userInManager.GetUserNameAsync(user);

            Username = userName;

            Input = new InputModel
            {
                Transcode = user.Transcode,
                Status = user.Status,
            };
        }

        [BindProperty]
        public FileViewModel FileUpload { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userInManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"ไม่สามารถโหลดข้อมูลของผู้ใช้ที่ไม่มี ID ได้ '{_userInManager.GetUserId(User)}'.");
            }
            if (Input.Transcode != user.Transcode)
            {
                user.Transcode = Input.Transcode;
            }
            if (Input.Status != user.Status)
            {
                user.Status = Input.Status;
            }
            if (!ModelState.IsValid)
            {
                StatusMessage = "ไฟล์รูปภาพไม่ถูกต้อง";
                return RedirectToPage();
            }
            if(FileUpload.FormFile.Length > 0)
            {
                using (var stream = new FileStream(Path.Combine(_hostEnvironment.WebRootPath, "uploadfiles", FileUpload.FormFile.FileName), FileMode.Create))
                {
                    await FileUpload.FormFile.CopyToAsync(stream);
                }
            }
            using (var memoryStream = new MemoryStream())
            {

                await FileUpload.FormFile.CopyToAsync(memoryStream);
                //var id = new Random().Next(0, 1000000);
                if (memoryStream.Length < 10495849)
                {
                    var file = new AppFile()
                    {
                        Transcode = Input.Transcode,
                        FileName = FileUpload.FormFile.FileName,
                        Content = memoryStream.ToArray()
                    };
                    _context.File.Add(file);

                    await _context.SaveChangesAsync();
                }
                else
                {
                    StatusMessage = "ขนาดไฟล์ใหญ่เกินไป";
                    ModelState.AddModelError("File", "ขนาดไฟล์ใหญ่เกินไป");
                    return RedirectToPage();
                }
            }
            StatusMessage = "คุณได้ส่งไฟล์รูปภาพสำเร็จ";
            return RedirectToPage();
        }
    }
}
