using System.ComponentModel.DataAnnotations;

namespace MyVet.Web.Data.Entities
{
    public class PetType
    {
        public int Id { get; set; }

        [Display(Name ="Pet Type")]
        [MaxLength(50, ErrorMessage ="El campo {0} no puede tener mas de {1} caracteres.")]
        [Required(ErrorMessage ="El campo {0} obligatorio.")]
        public string Name { get; set; }
    }
}
