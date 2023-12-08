using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalMelina.Models
{
    [Table("Procedimento")]
    public class Procedimento
    {
        [Column("Id")]
        [Display(Name = "Código do Procedimento")]
        public int Id { get; set; }

        [Column("ProcedimentoNome")]
        [Display(Name = "Nome do procedimento")]
        public string ProcedimentoNome { get; set; } = string.Empty;

        [Column("ProcedimentoObservacao")]
        [Display(Name = "Observação do Procedimento ")]
        public string ProcedimentoObservacao { get; set; } = string.Empty;

        [ForeignKey("TipoprocedimentoId")]
        [Display(Name = "Tipo de Procedimento")]
        public int TipoProcedimentoId { get; set; }
        [Display(Name = "Tipo de Procedimento")]
        public TipoProcedimento? TipoProcedimento { get; set; }
    }
}
