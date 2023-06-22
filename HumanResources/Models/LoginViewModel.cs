using System.ComponentModel.DataAnnotations;

namespace HumanResources.Models
{
    public class LoginViewModel
    {
        [Display(Name = "E-Posta")]
        [Required(ErrorMessage = "{0} alan� bo� b�rak�lamaz!")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "L�tfen ge�erli bir e-posta yaz�n�z!")]
        public string? UserName { get; set; }

        [Display(Name = "Parola")]
        [Required(ErrorMessage = "{0} alan� bo� b�rak�lamaz!")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Display(Name = "Oturum A��k Kals�n")]
        public bool IsPersistent { get; set; }

        public string? ReturnUrl { get; set; }

    }
}