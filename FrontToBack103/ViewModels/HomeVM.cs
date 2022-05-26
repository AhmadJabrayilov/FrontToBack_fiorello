using FrontToBack103.Models;
using System.Collections.Generic;

namespace FrontToBack103.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> sliders { get; set; }
        public PageIntro PageIntro { get; set; }
        public IEnumerable<Product> products { get; set; }
        public IEnumerable<Category> categories { get; set; } 
    }
}
