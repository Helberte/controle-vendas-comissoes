using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace controle_vendas_comissoes.Model.Db.Entidades
{
    [Table("produto_tabela_preco")]
    public class ProdutoTabelaPreco : EntidadeBase
    {
        [Key]
        public int Id { get; set; }

        [Column("produto_id")]
        public int ProdutoId { get; set; }

        [Column("tabela_preco_id")]
        public int? TabelaPrecoId { get; set; }

    }
}
