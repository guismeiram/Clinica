﻿using System.ComponentModel.DataAnnotations;
using System;

namespace Clinica.DTOs.Consulta
{
    public class ReadConsultaDTO
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Numero { get; set; }
        public DateTime Data_Hora { get; set; }
        public string Especialidades { get; set; }
    }
}
