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

        /// <summary>
        /// Soma do total com desconto dos produtos
        /// </summary>
        [Column("total", TypeName = "decimal(12, 4)" )]
        public decimal Total { get; set; }

        [Column("porcentagem_desconto", TypeName = "decimal(12, 4)")]
        public decimal PorcentagemDesconto { get; set; }

        [Column("valor_desconto", TypeName = "decimal(12, 4)")]
        public decimal ValorDesconto { get; set; }

        /// <summary>
        /// Total calculado com base no total com desconto dos produtos
        /// </summary>
        [Column("total_com_desconto", TypeName = "decimal(12, 4)")]
        public decimal TotalComDesconto { get; set; }

        /// <summary>
        /// Soma geral sem desconto dos produtos
        /// </summary>
        [Column("total_geral", TypeName = "decimal(12, 4)")]
        public decimal TotalGeral { get; set; }
    }
}
 