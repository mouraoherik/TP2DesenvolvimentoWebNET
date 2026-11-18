using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DR4TP2.Pages.CityManager;

public class CityDetails : PageModel
{
    public string Mensagem;
    
    public IActionResult OnGet(string cityName)
    {
        if (cityName == null)
        {
            Console.WriteLine("Nao foi");
            return NotFound();
        }

        Mensagem = $"Você está vendo detalhes de {cityName}";
        return Page();
    }
}