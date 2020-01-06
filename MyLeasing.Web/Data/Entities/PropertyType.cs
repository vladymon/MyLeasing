using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyLeasing.Web.Data.Entities
{
    public class PropertyType
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede contener mas de {1} caracteres")]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        public ICollection<Property> Properties { get; set; }
        
    }
}
