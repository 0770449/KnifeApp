using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace KnifeApp.Models
{
    public class Knife
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        public string Type { get; set; }
        public string Colour { get; set; }
        public string Size { get; set; }
        public string Image { get; set; }

    }
}