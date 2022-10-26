using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen  Adınızı Giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen Soy Adınızı  Giriniz")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Lütfen Resim Adı Giriniz")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Lütfen Kullanıcı Adı Giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi  Giriniz")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen Şifreyi Tekrar  Giriniz")]
        [Compare("Password",ErrorMessage = "Şifreler Uyumu Değil")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Lütfen Mail Adresi  Giriniz")]
        public string Mail { get; set; }

    }
}
