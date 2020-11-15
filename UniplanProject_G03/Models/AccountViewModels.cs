using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Threading.Tasks;

namespace UniplanProject_G03.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "UserName")]
        //[EmailAddress]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "ชื่อ-สกุล : ")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "ชื่อเล่น : ")]
        public string Nick { get; set; }

        [Required]
        [Display(Name = "วันเกิด : ")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Dob { get; internal set; }

        [Required]
        [Display(Name = "เพศ : ")]
        public string Sex { get; set; }

        [Required]
        [Display(Name = "รหัสนักศึกษา : ")]
        public string StudentID { get; set; }

        [Required]
        [Display(Name = "มหาวิทยาลัย/วิทยาลัย : ")]
        public string University { get; set; }

        [Required]
        [Display(Name = "คณะ/สำนักวิชา : ")]
        public string Institute { get; set; }

        [Required]
        [Display(Name = "สาขา : ")]
        public string Branch { get; set; }

        [Required]
        [Display(Name = "ปีทื่ : ")]
        public string Year { get; set; }

        [Required]
        [Display(Name = "คติประจำใจ : ")]
        public string Motto { get; set; }

        [Required]
        [Display(Name = "รูปภาพประจำตัว : ")]
        public string Url { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "ชื่อผู้ใช้(E-mail) : ")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "รหัสผ่าน : ")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "รหัสผ่านอีกครั้ง : ")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        internal Task CopyToAsync(FileStream uploadimg)
        {
            throw new NotImplementedException();
        }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
