using AutoMapper;
using Clinica.Data;
using Clinica.DTOs.Consulta;
using Clinica.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Clinica.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConsultaController : ControllerBase
    {
        private ClinicaDbContext _context;
        private IMapper _mapper;

        public ConsultaController(ClinicaDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpPost]
        public IActionResult AdicionaConsulta([FromBody] CreateConsultaDTO consultaDto)
        {
            Consulta consulta = _mapper.Map<Consulta>(consultaDto);
            _context.Consultas.Add(consulta);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaConsultaPorId), new { Id = consulta.Id }, consulta);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaConsultaPorId(int id)
        {
            Consulta consulta = _context.Consultas.FirstOrDefault(consulta => consulta.Id == id);
            if (consulta != null)
            {
                ReadConsultaDTO consultaDto = _mapper.Map<ReadConsultaDTO>(consulta);
                return Ok(consultaDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaConsulta(int id, [FromBody] UpdateConsultaDTO consultaDto)
        {
            Consulta consulta = _context.Consultas.FirstOrDefault(consulta => consulta.Id == id);
            if (consulta == null)
            {
                return NotFound();
            }
            _mapper.Map(consultaDto, consulta);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaConsultaPorId), new { Id = consulta.Id }, consulta);
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaFilme(int id)
        {
            Consulta consulta = _context.Consultas.FirstOrDefault(consulta => consulta.Id == id);
            if (consulta == null)
            {
                return NotFound();
            }
            _context.Remove(consulta);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaConsultaPorId), new { Id = consulta.Id }, consulta);
        }

    }
}
