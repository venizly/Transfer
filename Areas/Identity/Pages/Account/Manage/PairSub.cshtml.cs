//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using ProjectFinal1.Areas.Identity.Data;
//using System.ComponentModel.DataAnnotations;

//namespace ProjectFinal1.Areas.Identity.Pages.Account.Manage
//{
//    public class PairSubModel : PageModel
//    {
//        private readonly UserManager<AppilcationUser> _userManager;
//        private readonly SignInManager<AppilcationUser> _signInManager;

//        public PairSubModel(
//            UserManager<AppilcationUser> userManager,
//            SignInManager<AppilcationUser> signInManager)
//        {
//            _userManager = userManager;
//            _signInManager = signInManager;
//        }

//        /// <summary>
//        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
//        ///     directly from your code. This API may change or be removed in future releases.
//        /// </summary>
//        public string Username { get; set; }

//        /// <summary>
//        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
//        ///     directly from your code. This API may change or be removed in future releases.
//        /// </summary>
//        [TempData]
//        public string StatusMessage { get; set; }

//        /// <summary>
//        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
//        ///     directly from your code. This API may change or be removed in future releases.
//        /// </summary>
//        [BindProperty]
//        public InputModel Input { get; set; }

//        /// <summary>
//        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
//        ///     directly from your code. This API may change or be removed in future releases.
//        /// </summary>
//        public class InputModel
//        {
//            /// <summary>
//            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
//            ///     directly from your code. This API may change or be removed in future releases.
//            /// </summary>
//        [Display(Name = "CourseCs1")]public string CourseCs1 { get; set; }[Display(Name = "CourseTra1")]public string CourseTra1 { get; set; }
//        [Display(Name = "SubjectCs1")]public string SubjectCs1 { get; set; }[Display(Name = "SubjectTra1")]public string SubjectTra1 { get; set; }

//        [Display(Name = "CourseCs2")]public string CourseCs2 { get; set; }[Display(Name = "CourseTra2")]public string CourseTra2 { get; set; }
//        [Display(Name = "SubjectCs2")]public string SubjectCs2 { get; set; }[Display(Name = "SubjectTra2")]public string SubjectTra2 { get; set; }

//        [Display(Name = "CourseCs3")]public string CourseCs3 { get; set; }[Display(Name = "CourseTra3")]public string CourseTra3 { get; set; }
//        [Display(Name = "SubjectCs3")]public string SubjectCs3 { get; set; }[Display(Name = "SubjectTra3")]public string SubjectTra3 { get; set; }

//        [Display(Name = "CourseCs4")]public string CourseCs4 { get; set; }[Display(Name = "CourseTra1")]public string CourseTra4 { get; set; }
//        [Display(Name = "SubjectCs4")]public string SubjectCs4 { get; set; }[Display(Name = "SubjectTra4")]public string SubjectTra4 { get; set; }

//        [Display(Name = "CourseCs5")]public string CourseCs5 { get; set; }[Display(Name = "CourseTra5")]public string CourseTra5 { get; set; }
//        [Display(Name = "SubjectCs5")]public string SubjectCs5 { get; set; }[Display(Name = "SubjectTra5")]public string SubjectTra5 { get; set; }

//        [Display(Name = "CourseCs6")]public string CourseCs6 { get; set; }[Display(Name = "CourseTra6")]public string CourseTra6 { get; set; }
//        [Display(Name = "SubjectCs6")]public string SubjectCs6 { get; set; }[Display(Name = "SubjectTra6")]public string SubjectTra6 { get; set; }

//        [Display(Name = "CourseCs7")]public string CourseCs7 { get; set; }[Display(Name = "CourseTra7")]public string CourseTra7 { get; set; }
//        [Display(Name = "SubjectCs7")]public string SubjectCs7 { get; set; }[Display(Name = "SubjectTra7")]public string SubjectTra7 { get; set; }

//        [Display(Name = "CourseCs8")]public string CourseCs8 { get; set; }[Display(Name = "CourseTra8")]public string CourseTra8 { get; set; }
//        [Display(Name = "SubjectCs8")]public string SubjectCs8 { get; set; }[Display(Name = "SubjectTra8")]public string SubjectTra8 { get; set; }

//        [Display(Name = "CourseCs9")]public string CourseCs9 { get; set; }[Display(Name = "CourseTra9")]public string CourseTra9 { get; set; }
//        [Display(Name = "SubjectCs9")]public string SubjectCs9 { get; set; }[Display(Name = "SubjectTra9")]public string SubjectTra9 { get; set; }

//        [Display(Name = "CourseCs10")]public string CourseCs10 { get; set; }[Display(Name = "CourseTra10")]public string CourseTra10 { get; set; }
//        [Display(Name = "SubjectCs10")]public string SubjectCs10 { get; set; }[Display(Name = "SubjectTra10")]public string SubjectTra10 { get; set; }

//        [Display(Name = "CourseCs11")]public string CourseCs11 { get; set; }[Display(Name = "CourseTra11")]public string CourseTra11 { get; set; }
//        [Display(Name = "SubjectCs11")]public string SubjectCs11 { get; set; }[Display(Name = "SubjectTra11")]public string SubjectTra11 { get; set; }

//        [Display(Name = "CourseCs12")]public string CourseCs12 { get; set; }[Display(Name = "CourseTra12")]public string CourseTra12 { get; set; }
//        [Display(Name = "SubjectCs12")]public string SubjectCs12 { get; set; }[Display(Name = "SubjectTra12")]public string SubjectTra12 { get; set; }

//        [Display(Name = "CourseCs13")]public string CourseCs13 { get; set; }[Display(Name = "CourseTra13")]public string CourseTra13 { get; set; }
//        [Display(Name = "SubjectCs13")]public string SubjectCs13 { get; set; }[Display(Name = "SubjectTra13")]public string SubjectTra13 { get; set; }
//        }

//        private async Task LoadAsync(AppilcationUser user)
//        {
//            var userName = await _userManager.GetUserNameAsync(user);

//            Username = userName;

//            Input = new InputModel
//            {
//                CourseCs1 = user.CourseCs1, CourseTra1 = user.CourseTra1, SubjectCs1 = user.SubjectCs1, SubjectTra1 = user.SubjectTra1,
//                CourseCs2 = user.CourseCs2, CourseTra2 = user.CourseTra2, SubjectCs2 = user.SubjectCs2, SubjectTra2 = user.SubjectTra2,
//                CourseCs3 = user.CourseCs3, CourseTra3 = user.CourseTra3, SubjectCs3 = user.SubjectCs3, SubjectTra3 = user.SubjectTra3,
//                CourseCs4 = user.CourseCs4, CourseTra4 = user.CourseTra4, SubjectCs4 = user.SubjectCs4, SubjectTra4 = user.SubjectTra4,
//                CourseCs5 = user.CourseCs5, CourseTra5 = user.CourseTra5, SubjectCs5 = user.SubjectCs5, SubjectTra5 = user.SubjectTra5,
//                CourseCs6 = user.CourseCs6, CourseTra6 = user.CourseTra6, SubjectCs6 = user.SubjectCs6, SubjectTra6 = user.SubjectTra6,
//                CourseCs7 = user.CourseCs7, CourseTra7 = user.CourseTra7, SubjectCs7 = user.SubjectCs7, SubjectTra7 = user.SubjectTra7,
//                CourseCs8 = user.CourseCs8, CourseTra8 = user.CourseTra8, SubjectCs8 = user.SubjectCs8, SubjectTra8 = user.SubjectTra8,
//                CourseCs9 = user.CourseCs9, CourseTra9 = user.CourseTra9, SubjectCs9 = user.SubjectCs9, SubjectTra9 = user.SubjectTra9,
//                CourseCs10 = user.CourseCs10, CourseTra10 = user.CourseTra10, SubjectCs10 = user.SubjectCs10, SubjectTra10 = user.SubjectTra10,
//                CourseCs11 = user.CourseCs11, CourseTra11 = user.CourseTra11, SubjectCs11 = user.SubjectCs11, SubjectTra11 = user.SubjectTra11,
//                CourseCs12 = user.CourseCs12, CourseTra12 = user.CourseTra12, SubjectCs12 = user.SubjectCs12, SubjectTra12 = user.SubjectTra12,
//                CourseCs13 = user.CourseCs13, CourseTra13 = user.CourseTra13, SubjectCs13 = user.SubjectCs13, SubjectTra13 = user.SubjectTra13,
//            };
//        }

//        public async Task<IActionResult> OnGetAsync()
//        {
//            var user = await _userManager.GetUserAsync(User);
//            if (user == null)
//            {
//                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
//            }

//            await LoadAsync(user);
//            return Page();
//        }

//        public async Task<IActionResult> OnPostAsync()
//        {
//            var user = await _userManager.GetUserAsync(User);
//            if (user == null)
//            {
//                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
//            }

//            if (!ModelState.IsValid)
//            {
//                await LoadAsync(user);
//                return Page();
//            }

//            //if(Input.CreditCs1 != Input.CreditTra1)
//            //{
//            //    await _signInManager.RefreshSignInAsync(user);
//            //    StatusMessage = "เทียบโอนวิชาตัวที่ 1 หน่วยกิตไม่ผ่าน";
//            //    return Page();
//            //}
//            //else
//            //{
//            //    user.CreditCs1 = Input.CreditCs1;
//            //    user.CreditTra1 = Input.CreditTra1;
//            //}

//            if (Input.SubjectCs1 != user.SubjectCs1)    {user.SubjectCs1 = Input.SubjectCs1;}
//            if (Input.SubjectTra1 != user.SubjectTra1)  { user.SubjectTra1 = Input.SubjectTra1;}
//            if (Input.CourseCs1 != user.CourseCs1)      { user.CourseCs1 = Input.CourseCs1;}
//            if (Input.CourseTra1 != user.CourseTra1)    { user.CourseTra1 = Input.CourseTra1;}

//            //////////////////////////////////////////

//            if (Input.SubjectCs2 != user.SubjectCs2)    {user.SubjectCs2 = Input.SubjectCs2;}
//            if (Input.SubjectTra2 != user.SubjectTra2)  {user.SubjectTra2 = Input.SubjectTra2;}
//            if (Input.CourseCs2 != user.CourseCs2)      {user.CourseCs2 = Input.CourseCs2;}
//            if (Input.CourseTra2 != user.CourseTra2)    {user.CourseTra2 = Input.CourseTra2;}

//            //////////////////////////////////////////

//            if (Input.SubjectCs3 != user.SubjectCs3)    { user.SubjectCs3 = Input.SubjectCs3; }
//            if (Input.SubjectTra3 != user.SubjectTra3)  { user.SubjectTra3 = Input.SubjectTra3; }
//            if (Input.CourseCs3 != user.CourseCs3)      { user.CourseCs3 = Input.CourseCs3; }
//            if (Input.CourseTra3 != user.CourseTra3)    { user.CourseTra3 = Input.CourseTra3; }

//            //////////////////////////////////////////

//            if (Input.SubjectCs4 != user.SubjectCs4)    { user.SubjectCs4 = Input.SubjectCs4; }
//            if (Input.SubjectTra4 != user.SubjectTra4)  { user.SubjectTra4 = Input.SubjectTra4; }
//            if (Input.CourseCs4 != user.CourseCs4)      { user.CourseCs4 = Input.CourseCs4; }
//            if (Input.CourseTra4 != user.CourseTra4)    { user.CourseTra4 = Input.CourseTra4; }

//            //////////////////////////////////////////

//            if (Input.SubjectCs5 != user.SubjectCs5)    { user.SubjectCs5 = Input.SubjectCs5; }
//            if (Input.SubjectTra5 != user.SubjectTra5)  { user.SubjectTra5 = Input.SubjectTra5; }
//            if (Input.CourseCs5 != user.CourseCs5)      { user.CourseCs5 = Input.CourseCs5; }
//            if (Input.CourseTra5 != user.CourseTra5)    { user.CourseTra5 = Input.CourseTra5; }

//            //////////////////////////////////////////

//            if (Input.SubjectCs6 != user.SubjectCs6)    { user.SubjectCs6 = Input.SubjectCs6; }
//            if (Input.SubjectTra6 != user.SubjectTra6)  { user.SubjectTra6 = Input.SubjectTra6; }
//            if (Input.CourseCs6 != user.CourseCs6)      { user.CourseCs6 = Input.CourseCs6; }
//            if (Input.CourseTra6 != user.CourseTra6)    { user.CourseTra6 = Input.CourseTra6; }

//            //////////////////////////////////////////

//            if (Input.SubjectCs7 != user.SubjectCs7) { user.SubjectCs7 = Input.SubjectCs7; }
//            if (Input.SubjectTra7 != user.SubjectTra7) { user.SubjectTra7 = Input.SubjectTra7; }
//            if (Input.CourseCs7 != user.CourseCs7) { user.CourseCs7 = Input.CourseCs7; }
//            if (Input.CourseTra7 != user.CourseTra7) { user.CourseTra7 = Input.CourseTra7; }

//            //////////////////////////////////////////

//            if (Input.SubjectCs8 != user.SubjectCs8) { user.SubjectCs8 = Input.SubjectCs8; }
//            if (Input.SubjectTra8 != user.SubjectTra8) { user.SubjectTra8 = Input.SubjectTra8; }
//            if (Input.CourseCs8 != user.CourseCs8) { user.CourseCs8 = Input.CourseCs8; }
//            if (Input.CourseTra8 != user.CourseTra8) { user.CourseTra8 = Input.CourseTra8; }

//            //////////////////////////////////////////

//            if (Input.SubjectCs9 != user.SubjectCs9) { user.SubjectCs9 = Input.SubjectCs9; }
//            if (Input.SubjectTra9 != user.SubjectTra9) { user.SubjectTra9 = Input.SubjectTra9; }
//            if (Input.CourseCs9 != user.CourseCs9) { user.CourseCs9 = Input.CourseCs9; }
//            if (Input.CourseTra9 != user.CourseTra9) { user.CourseTra9 = Input.CourseTra9; }

//            //////////////////////////////////////////

//            if (Input.SubjectCs10 != user.SubjectCs10) { user.SubjectCs10 = Input.SubjectCs10; }
//            if (Input.SubjectTra10 != user.SubjectTra10) { user.SubjectTra10 = Input.SubjectTra10; }
//            if (Input.CourseCs10 != user.CourseCs10) { user.CourseCs10 = Input.CourseCs10; }
//            if (Input.CourseTra10 != user.CourseTra10) { user.CourseTra10 = Input.CourseTra10; }

//            /////////////////////////////////////////
            
//            if (Input.SubjectCs11 != user.SubjectCs11) { user.SubjectCs11 = Input.SubjectCs11; }
//            if (Input.SubjectTra11 != user.SubjectTra11) { user.SubjectTra11 = Input.SubjectTra11; }
//            if (Input.CourseCs11 != user.CourseCs11) { user.CourseCs11 = Input.CourseCs11; }
//            if (Input.CourseTra11 != user.CourseTra11) { user.CourseTra11 = Input.CourseTra11; }

//            /////////////////////////////////////////

//            if (Input.SubjectCs12 != user.SubjectCs12) { user.SubjectCs12 = Input.SubjectCs12; }
//            if (Input.SubjectTra12 != user.SubjectTra12) { user.SubjectTra12 = Input.SubjectTra12; }
//            if (Input.CourseCs12 != user.CourseCs12) { user.CourseCs12 = Input.CourseCs12; }
//            if (Input.CourseTra12 != user.CourseTra12) { user.CourseTra12 = Input.CourseTra12; }

//            /////////////////////////////////////////

//            if (Input.SubjectCs13 != user.SubjectCs13) { user.SubjectCs13 = Input.SubjectCs13; }
//            if (Input.SubjectTra13 != user.SubjectTra13) { user.SubjectTra13 = Input.SubjectTra13; }
//            if (Input.CourseCs13 != user.CourseCs13) { user.CourseCs13 = Input.CourseCs13; }
//            if (Input.CourseTra13 != user.CourseTra13) { user.CourseTra13 = Input.CourseTra13; }


//            await _userManager.UpdateAsync(user);
//            await _signInManager.RefreshSignInAsync(user);
//            StatusMessage = "ส่งข้อมูลวิชาเทียบโอนสำเร็จ";
//            return RedirectToPage();
//        }
//    }
//}
