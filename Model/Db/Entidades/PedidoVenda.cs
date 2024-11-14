using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace controle_vendas_comissoes.Model.Db.Entidades
{
    [Table("pedido_venda")]
    public class PedidoVenda : EntidadeBase
    {
        [Key]
        public int Id { get; set; }

        public DateTime Data { get; set; }

        public string Status { get; set; } = string.Empty;

        [Column("total", TypeName = "decimal(12, 4)" )]
        public decimal Total { get; set; }

        [Column("porcentagem_desconto", TypeName = "decimal(12, 4)")]
        public decimal PorcentagemDesconto { get; set; }
    }
}
 