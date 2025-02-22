using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MuziCodeWepApp.Models
{
    public class Manager: Entity
    {
        public int ManagerRole_ID { get; set; }
        [ForeignKey("ManagerRole_ID")]
        public virtual ManagerRole managerRole { get; set; } 

        [Display(Name = "Isim")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [StringLength(maximumLength:75, ErrorMessage = "En fazla 70 karakter girebilirsiniz.")]
        public string Name { get; set; }
        [Display(Name = "Soyisim")]
        [StringLength(maximumLength: 75, ErrorMessage = "En fazla 70 karakter girebilirsiniz.")]
        public string Surname { get; set; }

        [Display(Name = "E-posta")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [DataType(DataType.EmailAddress)]
        [StringLength(maximumLength:200,MinimumLength =5, ErrorMessage = "Bu alana 5 - 200 karakter arasında olabilir.")]
        
        public string Mail { get; set; }

        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [StringLength(maximumLength: 20, MinimumLength =5, ErrorMessage = "Bu alana 5 - 20 karakter arasında olabilir.")]
        public string Password { get; set; }


        public bool IsActive { get; set; }
    }
}