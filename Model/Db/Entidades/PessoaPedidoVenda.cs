using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace controle_vendas_comissoes.Model.Db.Entidades
{
    [Table("pessoa_pedido_venda")]
    public class PessoaPedidoVenda : EntidadeBase
    {
        [Key]
        public int Id { get; set; }

        [Column("pedido_venda_id")]
        public int PedidoVendaId { get; set; }

        [Column("pessoa_id")]
        public int PessoaId { get; set; }
    }
}
 