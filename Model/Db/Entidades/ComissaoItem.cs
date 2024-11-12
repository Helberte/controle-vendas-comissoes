using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace controle_vendas_comissoes.Model.Db.Entidades
{
    [Table("comissao_item")]
    public class ComissaoItem : EntidadeBase
    {
        [Key]
        public int Id { get; set; }

        public decimal Porcentagem { get; set; }

        [Column("valor_real")]
        public decimal ValorReal { get; set; }

        [Column("produto_id")]
        public int ProdutoId { get; set; }

        [Column("comissao_id")]
        public int ComissaoId { get; set; }
    }
}
