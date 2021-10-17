using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratorioN2.Dominio
{
    public class PersonaViewModel
    {
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "DATO REQUERIDO")]
        public string Nombre { get; set; }

        [Display(Name = "Edad")]
        [Required(ErrorMessage = "DATO REQUERIDO")]
        [Range(18, int.MaxValue, ErrorMessage = "LO SIENTO ERES MENOR DE EDAD")]
        public int Edad { get; set; }

        [Display(Name = "Descripcion")]
        [Required(ErrorMessage = "DATO REQUERIDO")]
        public string Descripcion { get; set; }
    }
}
