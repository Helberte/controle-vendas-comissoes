﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace controle_vendas_comissoes.Model.Db.Entidades
{
    [Table("pedido_venda_item")]
    public class PedidoVendaItem : EntidadeBase
    {
        [Key]
        public int Id { get; set; }

        [Column("quantidade", TypeName = "decimal(12, 4)" )]
        public decimal Quantidade { get; set; }

        [Column("total", TypeName = "decimal(12, 4)")]
        public decimal Total { get; set; }

        [Column("porcentagem_desconto", TypeName = "decimal(12, 4)")]
        public decimal PorcentagemDesconto { get; set; }

        [Column("pedido_venda_id")]
        public int PedidoVendaId { get; set; }
         
        [Column("produto_id")]
        public int ProdutoId { get; set; }
    }
}
 