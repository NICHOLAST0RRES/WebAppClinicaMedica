using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;

namespace WebApplication1.Models;

public class Consulta
{

    public UniqueId Id { get; }
    private Medico MedicoId { get; }
    private Paciente Paciente { get; }
    private DateTime Data { get; }
    private string Status { get; }


    public Consulta(Medico MedicoId, Paciente PacienteId ,DateTime Data, string Status )
    {
        this.MedicoId = MedicoId;
        this.Paciente = PacienteId;
        this.Data = Data;
        this.Status = Status;
    }
}

