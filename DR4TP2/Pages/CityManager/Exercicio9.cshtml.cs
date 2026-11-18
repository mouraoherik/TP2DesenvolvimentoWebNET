using DR4TP2.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DR4TP2.Pages.CityManager;

public class Exercicio9 : PageModel
{

    public List<City> Cities = new()
    {
        new() { CityName = "Rio de Janeiro" },
        new() { CityName = "São Paulo" },
        new() { CityName = "Brasília" }
    };
    
    public void OnGet()
    {
        
    }
}