using Clinica.Models;
using Microsoft.EntityFrameworkCore;

namespace Clinica.Data
{
    public class ClinicaDbContext : DbContext
    {
        public ClinicaDbContext(DbContextOptions<ClinicaDbContext> options) : base(options)
        {

        }

        public DbSet<Consulta> Consultas { get; set; }

    }
}
