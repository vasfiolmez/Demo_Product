using System.ComponentModel.DataAnnotations;

namespace Demo_Product.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen isim  Giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Soyisim  Giriniz")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Lütfen Kullanıcı  Giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen mail  Giriniz")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Lütfen şifre  Giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifre tekrar giriniz")]
        [Compare("Password",ErrorMessage ="lütfen şifrelerin eşleştiğinden emin olun.")]
        public string ConfirmPassword { get; set; }
        

    }
}
