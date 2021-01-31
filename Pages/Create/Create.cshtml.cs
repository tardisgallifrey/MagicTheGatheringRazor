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

        [BindProperty]
        public int CardPower { get; set; }

        [BindProperty]
        public int CardToughness { get; set; }

        [BindProperty]
        public int CardNumber_inSet { get; set; }

        [BindProperty]
        public int CardSetTotal { get; set; }

        [BindProperty]
        public string CardRules { get; set; }

        [BindProperty]
        public string CardFlavor { get; set; }

        public async Task OnPostAsync()
        {
            var dblink = new Magic_DBContext();
            var card = new Cards(CardName, CardRarity, CardSet_Name);

            card.Power = CardPower;
            card.Toughness = CardToughness;
            card.Rules_Text = CardRules;
            card.Number_in_Set = CardNumber_inSet;
            card.Set_Size = CardSetTotal;
            card.FlavorText = CardFlavor;

            dblink.Add<Cards>(card);
            await dblink.SaveChangesAsync();


        }
    }
}
