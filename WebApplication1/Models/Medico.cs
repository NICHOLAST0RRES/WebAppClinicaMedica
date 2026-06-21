using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;

namespace WebApplication1.Models;

public class Medico
{
    
    public UniqueId Id;
    public string Nome { get; set; }
    public string Crm { get; set; }
    public DateTime DataNascimento { get; set; }
    public Especialidade  Especialidade { get; set; }


    public Medico(string nome, DateTime dataNascimento, Especialidade esp, string crm)
    {
        this.Nome = nome;
        this.DataNascimento = dataNascimento;   
        this.Especialidade = esp;
        this.Crm = crm ; 
    }
}