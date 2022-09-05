using AutoMapper;
using Clinica.DTOs.Consulta;
using Clinica.Models;

namespace Clinica.Profiles
{
    public class ConsultaProfile : Profile
    {
        public ConsultaProfile()
        {
            CreateMap<CreateConsultaDTO, Consulta>();
            CreateMap<Consulta, ReadConsultaDTO>();
            CreateMap<UpdateConsultaDTO, Consulta>();
        }
    }
}
