using System;

namespace Clinica.DTOs.Consulta
{
    public class UpdateConsultaDTO
    {
        public string Numero { get; set; }
        public DateTime Data_Hora { get; set; }
        public string Especialidades { get; set; }
    }
}
