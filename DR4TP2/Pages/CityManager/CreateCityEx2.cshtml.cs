using DR4TP2.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;

namespace DR4TP2.Pages;

public class CreateCityEx2 : PageModel
{
    //     Exercicio 2
    //
    //     Remova a propriedade pública vinculada.
    //     Adicione um parâmetro string cityName no método OnPost.
    //     Exiba a mensagem com o nome da cidade recebida via handler.
    
    public string Mensagem { get; set; }
    
    public void OnGet()
    {
        
    }

    public void OnPost(string cityName)
    {
        if (!StringValues.IsNullOrEmpty(cityName))
        {
             Mensagem = $"Vocẽ enviou a cidade \"{cityName}\"";
        }
        else
        { 
            Mensagem = "Nenhum nome de cidade foi enviado.";
        }
    }
    
}