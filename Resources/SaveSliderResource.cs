using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace robotistan.Resources
{
    public class SaveSliderResource
    {
        [Required]
        public string Resim { get; set; }
        [Required]
        public string SliderLink { get; set; }
    }
}
