using System.ComponentModel.DataAnnotations;
using DR4TP2.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DR4TP2.Pages.CountryManager;

public class CreateCountryEx7 : PageModel
{
    
    [BindProperty] public List<InputModelCountry> InputList { get; set; } = new List<InputModelCountry>();

    public List<Country> CountriesCreated = new List<Country>();


    public class InputModelCountry
    {
        [Required(ErrorMessage = "Nome do país é obrigatório")]
        public string CountryName { get; set; }
        
        [Required(ErrorMessage = "Codigo do país é obrigatório." ),StringLength(2, MinimumLength = 2,ErrorMessage = "Codigo do pais deve ter exatamente {1} caracteres")]
        public string CountryCode { get; set; }
    }
    
    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        foreach (var v in InputList)
        {
            CountriesCreated.Add(new Country
            {
                CountryName = v.CountryName,
                CountryCode = v.CountryCode
            });
        }
        
        return Page();
    }

    public void OnGet()
    {
        for (int i = 0; i < 5; i++)
        {
            InputList.Add(new InputModelCountry());
        }
    }
}