using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyleasingWeb.Data.Entities
{
    public class PropertyType
    {
        public int Id { get; set; }

        [Display(Name = "Property Type")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string Name { get; set; }

        //agregamos la relacion de entidades ->
        //en este caso lo hacemos en ambas entidades para facilitar la consulta 
        public ICollection<Property> properties { get; set; }
    }

}

 
