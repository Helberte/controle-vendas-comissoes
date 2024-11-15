using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace controle_vendas_comissoes.Model.Db.Entidades
{
    [Table("unidade_primaria")]
    public class UnidadePrimaria : EntidadeBase
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public string Sigla { get; set; } = string.Empty;

        public ICollection<Produto>? Produtos { get; set; }
    }
}
