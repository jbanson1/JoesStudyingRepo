using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoesConsoleApp.Infrastructure.Models
{
    public class Category
    {
        [Required]
        public string Name { get; set; }

        public List<Subcategory> Subcategories { get; set; }
        
    }

    public class Subcategory 
    {
        public string Name { get; set; }  

        public string Description { get; set; }

        public List<Anothercategory> AnotherCatgory { get; set; }
        // possible use of a dictionary

    }

    public class Anothercategory
    {
        public string Detail { get; set; }
    }
}
