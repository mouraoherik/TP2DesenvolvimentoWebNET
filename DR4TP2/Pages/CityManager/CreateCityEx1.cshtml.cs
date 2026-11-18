using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace DR4TP2.Pages.CityManager;

public class CreateCityEx1 : PageModel
{
   [BindProperty] public InputModelCity Input { get; set; }
    public string Mensagem { get; set; }
    
    public void OnGet()
    {
        
    }

    public void OnPost()
    {
        if (Input != null && !string.IsNullOrWhiteSpace(Input.Nome) )
        {
            Mensagem = $"Vocẽ enviou a cidade \"{Input.Nome}\"";
        }
        else
        { 
            Mensagem = "Nenhum nome de cidade foi enviado.";
        }
    }
    
    public class InputModelCity
    {
        public string Nome { get; set; }
    }
    
}