using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ListaObecności.Models
{
    public class UserLogin
    {
        [Display(Name = "Email")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Wpisany adres e-mail nie jest poprawnym adresem")]
        public string EmailID { get; set; }

        [Display(Name = "Hasło")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Hasło musi składać się z minimum 6 znaków")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Zapamiętaj mnie")]
        public bool RememberMe { get; set; }
    }
}