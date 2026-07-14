using AutoMapper;
using WebApplication1.Dtos;
using WebApplication1.Models;

namespace WebApplication1.Mapping;

//automapper
public class MedicoProfile : Profile
{
    public  MedicoProfile()
    {
        // for read 
        CreateMap<Medico, MedicoResponseDTO>()
            
            // faco isso para a requisicao exibir o nome cardiologia enves do id
            .ForMember(dest => dest.EspecialidadeNome, opt => opt.MapFrom(src => src.Especialidade.Nome));
        
        // for write
        CreateMap<MedicoRequestDTO, Medico>(); 

        
    }
}