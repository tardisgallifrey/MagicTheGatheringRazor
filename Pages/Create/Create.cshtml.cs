using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MagicTheGatheringRazor.Pages.Create
{
    public class CreateModel : PageModel
    {
        public void OnGet()
        {
        }

        [BindProperty]
        public string CardName { get; set; }

        [BindProperty]
        public string CardRarity { get; set; }

        [BindProperty]
        public string CardSet_Name { get; set; }
        
        public void OnPost()
        {

        }
    }
}
