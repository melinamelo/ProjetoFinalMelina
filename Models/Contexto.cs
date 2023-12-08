using Microsoft.EntityFrameworkCore;
using ProjetoFinalMelina.Models;

namespace ProjetoFinalMelina.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<ProjetoFinalMelina.Models.Usuario>? Usuario { get; set; }
        public DbSet<ProjetoFinalMelina.Models.TipoProcedimento>? TipoProcedimento { get; set; }
        public DbSet<ProjetoFinalMelina.Models.TipoColaborador>? TipoColaborador { get; set; }
        public DbSet<ProjetoFinalMelina.Models.ProcedimentoRealizado>? ProcedimentoRealizado { get; set; }
        public DbSet<ProjetoFinalMelina.Models.Procedimento>? Procedimento { get; set; }
        public DbSet<ProjetoFinalMelina.Models.LocalRealizacao>? LocalRealizacao { get; set; }
        public DbSet<ProjetoFinalMelina.Models.Cidade>? Cidade { get; set; }
        public DbSet<ProjetoFinalMelina.Models.Cliente>? Cliente { get; set; }
        public DbSet<ProjetoFinalMelina.Models.Estado>? Estado { get; set; }
        public DbSet<ProjetoFinalMelina.Models.Colaborador>? Colaborador { get; set; }
     
    }
}
