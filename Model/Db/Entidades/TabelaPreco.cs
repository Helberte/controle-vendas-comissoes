using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace controle_vendas_comissoes.Model.Db.Entidades
{
    [Table("tabela_preco")]
    public class TabelaPreco : EntidadeBase
    {
        [Key]
        public int Id { get; set; }

        [Column("preco_custo")]
        public decimal PrecoCusto { get; set; }

        [Column("preco_venda")]
        public decimal PrecoVenda { get; set; }

        public int Ordem { get; set; }

        [Column("estado_id")]
        public int EstadoId { get; set; }
    }
}
