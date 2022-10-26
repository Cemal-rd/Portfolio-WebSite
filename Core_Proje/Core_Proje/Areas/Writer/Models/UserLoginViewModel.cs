using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "kullanıcı adını giriniz")]
        public string Username { get; set; }
        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifrenizi giriniz")]
        public string Password { get; set; }
    }
}
