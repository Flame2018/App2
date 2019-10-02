using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App2.Pages
{
    public class IndexModel : PageModel
    {
        public string[] GoodieNs { get; set; }
        public void OnGet()
        {
            GoodieNs = new string[] { "Coco Thunder", "Ghetto Delight", "Thug Sweetness", "Rough Rider" };
        }
    }
}
