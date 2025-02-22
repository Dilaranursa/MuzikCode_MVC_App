using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MuziCodeWepApp.Models
{
    public class ManagerRole:Entity
    {
        [Display(Name = "Rol Adı")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public string Name { get; set; }

        public virtual ICollection<Manager> Managers { get; set; } 
    }
}