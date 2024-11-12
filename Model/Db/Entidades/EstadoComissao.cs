using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace controle_vendas_comissoes.Model.Db.Entidades
{
    [Table("estado_comissao")]
    public class EstadoComissao : EntidadeBase
    {
        [Key]
        public int Id { get; set; }

        [Column("estado_id")]
        public int EstadoId { get; set; }

        [Column("comissao_id")]
        public int ComissaoId { get; set; }
    }
}
