using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;

namespace WebApplication1.Models;

public class Paciente
{
    [Key]
    public UniqueId Id; 
    private string Nome { get;}
    private Prontuario Prontuario { get;}
    private string Cpf { get;}
    private string telefone { get;}
    private string email { get;}
    private Convenio convenio { get;}

    public Paciente(string nome, Prontuario prontuario, string cpf, string telefone, string email,  Convenio convenio)
    {
        this.Nome = nome;
        this.Prontuario = prontuario;
        this.Cpf = cpf;
        this.telefone = telefone;
        this.email = email;
        this.convenio = convenio;
    }
}