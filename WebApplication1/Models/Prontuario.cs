using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;

namespace WebApplication1.Models;

public class Prontuario
{
    [Key]
    public UniqueId Id;
    private DateTime DataDeAbertura { get;}
    private RegistroEvolucao registroEvolucao { get;}


    public Prontuario()
    {
        DataDeAbertura = DateTime.Now;
        
    }
}


