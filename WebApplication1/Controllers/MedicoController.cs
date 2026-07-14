using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Dtos;
using WebApplication1.Infra;
using WebApplication1.Models;

namespace WebApplication1.Controllers;


[ApiController]
[Route("[controller]")]
public class MedicoController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;
    
    
    public MedicoController(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet ("{id}")]
    public async Task<ActionResult<MedicoResponseDTO>> BuscarMedico(int id)
    {
        // transformar um dto em um entidade atraves da interface Imapper
        var medico = await _context.Medicos
                
                // entender esse incluide 
            .Include(m => m.Especialidade)
            .FirstOrDefaultAsync(m => m.Id == id);
        
        
        if (medico is null) return NotFound();
        
        return Ok(_mapper.Map<MedicoResponseDTO>(medico));
    }
    
    [HttpPost]
    public async Task<ActionResult<MedicoRequestDTO>> CadastrarMedico(MedicoRequestDTO requestDto)
    {
        // transformar um dto em um entidade atraves da interface Imapper
        var medico = _mapper.Map<Medico>(requestDto);
        _context.Medicos.Add(medico); 
        await _context.SaveChangesAsync();
        
        
        var response = _mapper.Map<MedicoRequestDTO>(medico);
        return CreatedAtAction(nameof(BuscarMedico), new { id = medico.Id }, response);
        
        
    }
    


}