using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfoAPI.Models
{
    
    public class PointOfInterestCreationDto
    {
        [Required(ErrorMessage = "Add a name")]

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }

       
    }
}
