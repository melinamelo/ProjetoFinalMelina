using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalMelina.Models
{
    [Table("TipoColaborador")]
    public class TipoColaborador
    {
        [Column("Id")]
        [Display(Name = "Código do Tipo de colaborador")]
        public int Id { get; set; }

        [Column("TipoProcedimentoNome")]
        [Display(Name = "Tipo de colaborador")]
        public string TipoColaboradorNome { get; set; } = string.Empty;
    }
}
