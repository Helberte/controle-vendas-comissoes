using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace controle_vendas_comissoes.Model.Db.Entidades
{
    [Table("pedido_venda_item_comissao")]
    public class PedidoVendaItemComissao : EntidadeBase
    {
        [Key]
        public int Id { get; set; }

        [Column("pedido_venda_item_id")]
        public int PedidoVendaItemId { get; set; }

        [Column("pedido_venda_id")]
        public int PedidoVendaId { get; set; }

        [Column("comissao_item_id")]
        public int? ComissaoItemId { get; set; }

        [Column("comissao_id")]
        public int? ComissaoId { get; set; }

        [Column("classificacao_id")]
        public int? ClassificacaoId { get; set; }

        [Column("quantidade_vendida", TypeName = "decimal(12, 4)")]
        public decimal QuantidadeVendida { get; set; }

        [Column("valor_base", TypeName = "decimal(12, 4)")]
        public decimal ValorBase { get; set; }

        [Column("valor_comissao_item", TypeName = "decimal(12, 4)")]
        public decimal ValorComissaoItem { get; set; }

        [Column("total_comissao", TypeName = "decimal(12, 4)")]
        public decimal TotalComissao { get; set; }

        [Column("total", TypeName = "decimal(12, 4)")]
        public decimal Total { get; set; }
    }
}
 