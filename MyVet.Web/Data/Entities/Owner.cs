using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }

       [MaxLength(30, ErrorMessage ="El campo {0}  no puede tener mas de {1} caracteres.")]
       [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string document { get; set; } 

        [MaxLength(50, ErrorMessage = "El campo {0}  no puede tener mas de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0}  no puede tener mas de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [MaxLength(20, ErrorMessage = "El campo {0}  no puede tener mas de {1} caracteres.")]
        [Display(Name = "Fixed Phone")]
        public string FixedPhone { get; set; }

        [MaxLength(20, ErrorMessage = "El campo {0}  no puede tener mas de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Cell Phone")]
        public string CellPhone { get; set; }

        [MaxLength(100, ErrorMessage = "El campo {0}  no puede tener mas de {1} caracteres.")] 
        public string Address { get; set; }

        [Display(Name ="Owner")]
        public string FullName => $"{FirstName}{LastName} - {document}";

    }
}
