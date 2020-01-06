using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyLeasing.Web.Data.Entities
{
    public class Lessee
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Document { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede contener mas de {1} caracteres")]
        [Display(Name = "Nombre")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede contener mas de {1} caracteres")]
        [Display(Name = "Apellido")]
        public string LastName { get; set; }

        [MaxLength(20, ErrorMessage = "El campo {0} no puede contener mas de {1} caracteres")]
        [Display(Name = "Telefono")]
        public string FixedPhone { get; set; }

        [MaxLength(20, ErrorMessage = "El campo {0} no puede contener mas de {1} caracteres")]
        [Display(Name = "Celular")]
        public string CellPhone { get; set; }

        [Display(Name = "Dirección")]
        public string Address { get; set; }

        [Display(Name = "Nombre del arrendatario")]
        public string FullName => $"{FirstName} {LastName}";

        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";

        public ICollection<Contract> Contracts { get; set; }
    }
}
