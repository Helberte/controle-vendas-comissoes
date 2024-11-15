using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace controle_vendas_comissoes.Model.Db.Entidades
{
    [Table("produto")]
    public class Produto : EntidadeBase
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public string? Descricao { get; set; } = string.Empty;

        public string? Composicao { get; set; } = string.Empty;

        [Column("modo_usar")]
        public string? ModoUsar { get; set; } = string.Empty;

        public decimal? Peso { get; set; } = 0m;

        [Column("unidade_primaria_id")]
        public int? UnidadePrimariaId { get; set; }

        public UnidadePrimaria? UnidadePrimaria { get; set; }

    }
}
