using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data.Entities
{
    public class Pet
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        public string Race { get; set; }

        [Display(Name ="Born")]
        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString ="{0:yyyy/MM/dd}", ApplyFormatInEditMode =true)]
        public DateTime Born { get; set; }

        public string Remarks { get; set; }

        //  public ICollectionn<History> Hisories { get; set; }

        public string ImageFullPath => string.IsNullOrEmpty(ImageUrl)
            ? null
            : $"https://TBD.azurewebsites.net{ImageUrl.Substring(1)}";

        [Display(Name = "Data")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime BornLocal => Born.ToLocalTime();

        public PetType PetType { get; set; }
        public Owner Owner { get; set; }

        public ICollection<History> Histories { get; set; }

        public ICollection<Agenda> Agendas { get; set; }
    }
}
