using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;


namespace KnifeApp.Models
{
    public class KnifeTypeViewModel
    {
        public List<Knife> Knives { get; set; }
        public SelectList Types { get; set; }
        public string KnifeTypeSize { get; set; }
        public string SearchString { get; set; }
    }
}
