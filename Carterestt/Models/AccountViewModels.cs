using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Carterestt.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
<<<<<<< HEAD
        [Display(Name = "EMAIL")]
=======
        [Display(Name = "Адрес электронной почты")]
>>>>>>> d198e5d06df4f0db1032d3302f5e1e095185431e
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
<<<<<<< HEAD
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "")]
=======
        [Display(Name = "Код")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Запомнить браузер?")]
>>>>>>> d198e5d06df4f0db1032d3302f5e1e095185431e
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
<<<<<<< HEAD
        [Display(Name = "Email")]
=======
        [Display(Name = "Адрес электронной почты")]
>>>>>>> d198e5d06df4f0db1032d3302f5e1e095185431e
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
<<<<<<< HEAD
        [Display(Name = "Email")]
=======
        [Display(Name = "Адрес электронной почты")]
>>>>>>> d198e5d06df4f0db1032d3302f5e1e095185431e
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
<<<<<<< HEAD
        [Display(Name = "Парола")]
        public string Password { get; set; }

        [Display(Name = "Запази")]
=======
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Display(Name = "Запомнить меня")]
>>>>>>> d198e5d06df4f0db1032d3302f5e1e095185431e
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
<<<<<<< HEAD
        [Display(Name = "Еmail")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Стойността {0} трябва да съдържа поне {2} знака.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Парола")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Потвърдете парола")]
        [Compare("Password", ErrorMessage = "Моля, проверете правилно ли сте написали паролата")]
=======
        [Display(Name = "Адрес электронной почты")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Значение {0} должно содержать не менее {2} символов.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Подтверждение пароля")]
        [Compare("Password", ErrorMessage = "Пароль и его подтверждение не совпадают.")]
>>>>>>> d198e5d06df4f0db1032d3302f5e1e095185431e
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
<<<<<<< HEAD
        [Display(Name = "email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Стойността {0} трябва да съдържа поне {2} знака.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Паролa")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "потвърдете парола")]
        [Compare("Password", ErrorMessage = "Моля, проверете правилно ли сте написали паролата")]
=======
        [Display(Name = "Адрес электронной почты")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Значение {0} должно содержать не менее {2} символов.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Подтверждение пароля")]
        [Compare("Password", ErrorMessage = "Пароль и его подтверждение не совпадают.")]
>>>>>>> d198e5d06df4f0db1032d3302f5e1e095185431e
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
<<<<<<< HEAD
        [Display(Name = "Поща")]
=======
        [Display(Name = "Почта")]
>>>>>>> d198e5d06df4f0db1032d3302f5e1e095185431e
        public string Email { get; set; }
    }
}
