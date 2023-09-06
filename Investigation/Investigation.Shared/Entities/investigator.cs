using System.ComponentModel.DataAnnotations;


namespace Investigation.Shared.Entities
{
    public class Investigator

    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe terner maximo {1} caracteres")]
        [Required(ErrorMessage = "El campo{0} es obligatorio ")]
        public string Name { get; set; } = null!;

        [Display(Name = "Afiliacion Institucional")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe terner maximo {1} caracteres")]
        [Required(ErrorMessage = "El campo{0} es obligatorio ")]
        public string membership { get; set; } = null!;

        [Display(Name = "Especializacion")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe terner maximo {1} caracteres")]
        [Required(ErrorMessage = "El campo{0} es obligatorio ")]
        public string specialization { get; set; } = null!;



        [Display(Name = "Rol")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe terner maximo {1} caracteres")]
        [Required(ErrorMessage = "El campo{0} es obligatorio ")]
        public string role { get; set; } = null!;


    }
}
