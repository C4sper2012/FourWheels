using System.Collections.Generic;
using System.Threading.Tasks;
using FourWheels.Repository.Entities;
using FourWheels.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FourWheels.UI.Pages
{
    public class TakeAO : PageModel
    {
        private readonly IArbejdsOrdrerService _arbejdsOrdrerService;
        public TakeAO(IArbejdsOrdrerService arbejdsOrdrerService)
        {
            _arbejdsOrdrerService = arbejdsOrdrerService;
        }

        [BindProperty(SupportsGet = true)]
        public List<Arbejdsordrer> Arbejdsordrers { get; set; }

        public SelectList Mekanikere;
        [BindProperty(SupportsGet = true)]
        public InputModel Input { get; set; }


        public async Task OnGet()
        {
            Arbejdsordrers = await _arbejdsOrdrerService.GetAllAOIncludeMek();
            // TODO FIX MECHANIC SERVICE DAMMIT!
            List<Mekaiker> mekaikers = new List<Mekaiker>();
            mekaikers.Add(new Mekaiker{ PKMekanikerID = 1, Stilling = "Svend", Fornavn = "Hard", Efternavn = "Coded 1"});
            mekaikers.Add(new Mekaiker{ PKMekanikerID = 2, Stilling = "Svend", Fornavn = "Hard", Efternavn = "Coded 2"});
            mekaikers.Add(new Mekaiker{ PKMekanikerID = 3, Stilling = "Lærling", Fornavn = "Hard", Efternavn = "Coded 3"});
            Mekanikere = new SelectList(mekaikers, "PKMekanikerID", "Fuldenavn");
        }

        public async Task OnPost()
        {
            
        }
        
        public async Task<IActionResult> OnPostModal()
        {
            Arbejdsordrer ao = await _arbejdsOrdrerService.GetByIdAsync(Input.AOID);
            ao.FKMekanikerID = Input.MekID;
            _arbejdsOrdrerService.UpdateAsync(ao);
            return NotFound();
        }
    }

    public class InputModel
    {
        public int AOID { get; set; }
        public int MekID { get; set; }
    }
}