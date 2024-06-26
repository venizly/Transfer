﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ProjectFinal1.Areas.Identity.Data;
using ProjectFinal1.Models;
using static ProjectFinal1.Areas.Identity.Data.AppilcationUser;

namespace ProjectFinal1.Areas.Identity.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<AppilcationUser> _signInManager;
        private readonly UserManager<AppilcationUser> _userManager;
        private readonly IUserStore<AppilcationUser> _userStore;
        private readonly IUserEmailStore<AppilcationUser> _emailStore;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly IWebHostEnvironment _hostenvironment;
        private readonly ProjectFinal1.Data.ProjectDbContext _context;
        public List<SelectListItem> TraCourse { get; set; }
        public List<SelectListItem> CsCourse { get; set; }
        //public List<SelectListItem> Ins { get; set; }
        public RegisterModel(
            UserManager<AppilcationUser> userManager,
            IUserStore<AppilcationUser> userStore,
            SignInManager<AppilcationUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            IWebHostEnvironment webHostEnvironment,
            ProjectFinal1.Data.ProjectDbContext context
            )
        {
            _userManager = userManager;
            _userStore = userStore;
            _emailStore = GetEmailStore();
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _hostenvironment = webHostEnvironment;
            _context = context;
            TraCourse = _context.TraCourse.ToList().Select(a => new SelectListItem()
            {
                Text = a.Namecoursetra,
                Value = $"{a.Codecoursetra}"
            }).ToList();
            CsCourse = _context.CsCourse.ToList().Select(a => new SelectListItem()
            {
                Text = a.Namecoursecs,
                Value = $"{a.Codecoursecs}"
            }).ToList();

            //Ins = _context.Ins.ToList().Select(a => new SelectListItem()
            //{
            //    Text = a.InsName,
            //    Value = $"{a.InsCode}"
            //}).ToList();
        }


        [BindProperty]
        public InputModel Input { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public class InputModel
        {
            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "Transcode")]
            public string Transcode { get; set; }

            [DataType(DataType.Text)]
            [Display(Name = "CourseCs")]
            public string? CourseCs { get; set; }
            
            [Required]
            [Display(Name = "CourseCsId")]
            public int? CourseCsId { get; set; }

            [DataType(DataType.Text)]
            [Display(Name = "Facebook")]
            public string? Facebook { get; set; }

            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "Codecoursetra")]
            public int Codecoursetra { get; set; }

            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "Status")]
            public string Status { get; set; }

            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }


        }


        public async Task OnGetAsync(string returnUrl = null)
        {
            if (User.Identity.IsAuthenticated)
            {
                Response.Redirect("/");
            }
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }


        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {

            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            if (ModelState.IsValid)
            {
                string username = Input.Transcode ?? Input.Transcode;

                if (ModelState.IsValid)
                {
                    var User = new AppilcationUser
                    {
                        UserName = username,
                        Transcode = Input.Transcode,
                    };
                }


                var user = CreateUser();

                user.Email = Input.Email;
                user.Transcode = Input.Transcode;
                user.FirstName = Input.FirstName;
                user.LastName = Input.LastName;
                user.Codecoursetra = Input.Codecoursetra;
                //user.CourseCs = Input.CourseCs;
                user.CourseCsId = Input.CourseCsId;
                user.Facebook = "";
                user.Status = "";

                await _userStore.SetUserNameAsync(user, Input.Transcode, CancellationToken.None);
                //await _emailStore.SetEmailAsync(user, Input.Email, CancellationToken.None);
                var result = await _userManager.CreateAsync(user, Input.Password);

                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var userId = await _userManager.GetUserIdAsync(user);
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = userId, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }


            // If we got this far, something failed, redisplay form
            return Page();
        }

        private AppilcationUser CreateUser()
        {
            try
            {
                return Activator.CreateInstance<AppilcationUser>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(AppilcationUser)}'. " +
                    $"Ensure that '{nameof(AppilcationUser)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }

        private IUserEmailStore<AppilcationUser> GetEmailStore()
        {
            if (!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }
            return (IUserEmailStore<AppilcationUser>)_userStore;
        }
    }
}
