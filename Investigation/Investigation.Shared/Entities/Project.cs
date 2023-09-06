using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation.Shared.Entities
{
    public  class Project
    {
        public int Id { get; set; }

        [Display(Name="Proyecto")]
        [MaxLength(100,ErrorMessage ="El campo {0} debe terner maximo {1} caracteres")]
        [Required(ErrorMessage ="El campo{0} es obligatorio ")]
        public string Name { get; set; } = null;

        [Display(Name = "Descripcion")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe terner maximo {1} caracteres")]
        [Required(ErrorMessage = "El campo{0} es obligatorio ")]
        public string Description { get; set; } = null;

        [Display(Name = "Lider")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe terner maximo {1} caracteres")]
        [Required(ErrorMessage = "El campo{0} es obligatorio ")]
        public string Leader { get; set; } = null;

        [Display(Name = "area")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe terner maximo {1} caracteres")]
        [Required(ErrorMessage = "El campo{0} es obligatorio ")]
        public string area { get; set; } = null;

        public DateTime Date { get; set; }




    }
}
