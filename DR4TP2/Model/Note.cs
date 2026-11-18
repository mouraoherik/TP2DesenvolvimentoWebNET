using System.ComponentModel.DataAnnotations;

namespace DR4TP2.Model;

public class Note
{
    [Required(ErrorMessage = "A Mensagem é obrigatória.")]
    public string Mensagem { get; set; }
    public DateTime DateTime { get; set; }
}