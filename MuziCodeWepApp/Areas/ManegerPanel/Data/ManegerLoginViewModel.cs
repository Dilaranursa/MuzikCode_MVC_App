using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MuziCodeWepApp.Areas.ManegerPanel.Data
{
    public class ManegerLoginViewModel
    {
        [Display(Name = "E-posta")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [DataType(DataType.EmailAddress)]
        [StringLength(maximumLength: 200, MinimumLength = 5, ErrorMessage = "Bu alana 5 - 200 karakter arasında olabilir.")]
        public string Mail { get; set; }


        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [StringLength(maximumLength: 20, MinimumLength = 5, ErrorMessage = "Bu alana 5 - 20 karakter arasında olabilir.")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }

    }
}