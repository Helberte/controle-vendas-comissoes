using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace controle_vendas_comissoes.Model.Db.Entidades
{
    [Table("comissao_item")]
    public class ComissaoItem : EntidadeBase
    {
        [Key]
        public int Id { get; set; }

        [Column("porcentagem", TypeName = "decimal(12, 4)")]
        public decimal Porcentagem { get; set; }

        [Column("valor_real", TypeName = "decimal(12, 4)")]
        public decimal ValorReal { get; set; }

        [Column("produto_id")]
        public int ProdutoId { get; set; }

        [Column("comissao_id")]
        public int ComissaoId { get; set; }
    }
}
