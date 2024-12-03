using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace controle_vendas_comissoes.Model.Db.Entidades
{
    [Table("endereco")]
    public class Endereco : EntidadeBase
    {
        [Key]
        public int Id { get; set; }

        public string Rua { get; set; } = string.Empty;

        public string? Cep { get; set; } = string.Empty;

        public string? Numero { get; set; } = string.Empty;

        public string? Bairro { get; set; } = string.Empty;

        [Column("cidade_id")]
        public int CidadeId { get; set; }

        [Column("estado_id")]
        public int EstadoId { get; set; }
         
        public Cidade? Cidade { get; set; }

        public Estado? Estado { get; set; }
    }
}
