using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookingSystem.BuisnessLogic.Entities
{
    public class ExampleModel : BaseEnitity
    {
        [Required]
        [MinLength(3)]        
        public string Name { get; set; }

        //Hello Julia
    

    }
}
