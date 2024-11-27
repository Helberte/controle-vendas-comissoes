using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace controle_vendas_comissoes.Model.Db.Entidades
{
    [Table("comissao")]
    public class Comissao : EntidadeBase
    {
        [Key]
        public int Id { get; set; }

        [Column("classificacao_id")]
        public int ClassificacaoId { get; set; }

        [Column("produto_tabela_preco_id")]
        public int ProdutoTabelaPrecoId { get; set; }
    }
}
