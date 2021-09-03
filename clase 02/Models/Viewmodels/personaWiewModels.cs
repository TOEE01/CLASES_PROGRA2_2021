using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace clase_02.Models.Viewmodels
{
    public class PersonaWiewModels
    {
        [Display (Name ="Sid")]

        [Range(0,int.MaxValue,ErrorMessage ="No valido")]
        public int Id { get; set; }

        [Display(Name ="NOMBRE")]

        [Required(ErrorMessage ="Este campo es requerido")]
        public string Nombre { get; set; }
    }
}