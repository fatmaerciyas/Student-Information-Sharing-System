using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgiPaylasimSistemi.Models
{
    public class LoginViewModel
    {
        //[Display(Name = "Kullanıcı Adı")]
        //[Required(ErrorMessage = "Lütfen kullanıcı adı giriniz")]
        //public string UserName { get; set; }


        [Display(Name = "Kullanıcı Mail")]
        [Required(ErrorMessage = "Lütfen mail giriniz")]
        public string Email { get; set; }


        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Lütfen şifre giriniz")]
        public string Password { get; set; }
       
    }
}
