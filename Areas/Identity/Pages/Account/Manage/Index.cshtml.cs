﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectFinal1.Areas.Identity.Data;

namespace ProjectFinal1.Areas.Identity.Pages.Account.Manage
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<AppilcationUser> _userManager;
        private readonly SignInManager<AppilcationUser> _signInManager;

        public IndexModel(
            UserManager<AppilcationUser> userManager,
            SignInManager<AppilcationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [TempData]
        public string StatusMessage { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [BindProperty]
        public InputModel Input { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public class InputModel
        {
            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>

            [Display(Name = "Email")]
            public string Email { get; set; }

            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            [Display(Name = "InsCode")]
            public int InsCode { get; set; }

            [Display(Name = "Codecoursetra")]
            public int Codecoursetra { get; set; }

            [Display(Name = "Facebook")]
            public string Facebook { get; set; }

            [Display(Name = "Status")]
            public string Status { get; set; }

            [Phone]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }
        }

        private async Task LoadAsync(AppilcationUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);

            Username = userName;
            
            Input = new InputModel
            {
                Email = user.Email,
                PhoneNumber = phoneNumber,
                Codecoursetra = user.Codecoursetra,
                FirstName = user.FirstName,
                LastName = user.LastName,
                InsCode = user.InsCode,
                Facebook = user.Facebook,
                Status = user.Status,
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"ไม่สามารถโหลดข้อมูลของผู้ใช้ที่ไม่มี ID ได้ '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"ไม่สามารถโหลดข้อมูลของผู้ใช้ที่ไม่มี ID ได้ '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "เกิดข้อผิดพลาด โปรดใส่หมายเลขโทรศัพท์ให้ถูกต้อง.";
                    return RedirectToPage();
                }
            }

            if (Input.FirstName != user.FirstName)
            {
                user.FirstName = Input.FirstName;
            }

            if (Input.Email != user.Email)
            {
                user.Email = Input.Email;
            }

            if (Input.LastName != user.LastName)
            {
                user.LastName = Input.LastName;
            }

            if (Input.Codecoursetra != user.Codecoursetra)
            {
                user.Codecoursetra = Input.Codecoursetra;
            }

            if (Input.InsCode != user.InsCode)
            {
                user.InsCode = Input.InsCode;
            }

            if (Input.Facebook != user.Facebook)
            {
                user.Facebook = Input.Facebook;
            }



            await _userManager.UpdateAsync(user);
            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "คุณอัพเดทข้อมูลสำเร็จ";
            return RedirectToPage();
        }
    }
}
