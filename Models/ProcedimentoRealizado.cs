using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalMelina.Models
{
    [Table("ProcedimentoRealizado")]
    public class ProcedimentoRealizado
    {
        [Column("Id")]
        [Display(Name = "Código do procedimento realizado")]
        public int Id { get; set; }

        [ForeignKey("ClienteId")]
        [Display(Name = "Nome do Cliente")]
        public int? ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

        [ForeignKey("ProcedimentoId")]
        [Display(Name = "Procedimento")]
        public int? ProcedimentoId { get; set; }
        public Procedimento? Procedimento { get; set; }

        [ForeignKey("ColaboradorId")]
        [Display(Name = "Nome do Colaborador")]
        public int? ColaboradorId { get; set; }
        public Colaborador? Colaborador { get; set; }

        [ForeignKey("LocalRealizacaoId")]
        [Display(Name = "Local de Realização")]
        public int? LocalRealizacaoId { get; set; }
        [Display(Name = "Local de Realização")]
        public LocalRealizacao? LocalRealizacao { get; set; }

        [Column("DataRealizacao")]
        [Display(Name = "Data de Realização")]
        public DateTime DataRealizacao { get; set; }

        [Column("ObservacaoRealizacao")]
        [Display(Name = "Observação da realização ")]
        public string ObservacaoRealizacao { get; set; } = string.Empty;
    }
}
