using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MagicTheGathering.Data;
using MagicTheGathering.Models;

#nullable disable

namespace MagicTheGatheringRazor.Pages.Create
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public string CardName { get; set; }

        [BindProperty]
        public int CardRarity { get; set; }

        [BindProperty]
        public string CardSet_Name { get; set; }

        public async Task OnPostAsync()
        {
            var dblink = new Magic_DBContext();
            var card = new Cards(CardName, CardRarity, CardSet_Name);

            dblink.Add<Cards>(card);
            await dblink.SaveChangesAsync();


        }
    }
}
