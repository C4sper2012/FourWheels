using FourWheels.Repository.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FourWheels.web.Pages;

public class CreateAO : PageModel
{
    [BindProperty]
    public Arbejdsordrer ArbejdsOrdrer { get; set; }
    public void OnGet()
    {
        
    }
}