using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratorioN2.Dominio
{
    public class persona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPersona { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "DATO REQUERIDO")]
        public string NombrePersona { get; set; }


        [Display(Name = "Edad")]
        [Required(ErrorMessage = "DATO REQUERIDO")]
        [Range(18, int.MaxValue, ErrorMessage = "LO SIENTO ERES MENOR DE EDAD")]
        public int EdadPersona { get; set; }

        [Display(Name = "Descripcion")]
        [Required(ErrorMessage = "DATO REQUERIDO")]
        public string DescripcionPersona { get; set; }

        //public ICollection<persona> personas { get; set; }
    }
}
