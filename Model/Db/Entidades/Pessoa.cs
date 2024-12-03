using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace controle_vendas_comissoes.Model.Db.Entidades
{
    [Table("pessoa")]
    public class Pessoa : EntidadeBase
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public string Sobrenome { get; set; } = string.Empty;

        public string Cpf { get; set; } = string.Empty;

        public string Rg { get; set; } = string.Empty;

        [Column("data_nascimento")]
        public DateTime? DataNascimento { get; set; }

        [Column("classificacao_id")]
        public int? ClassificacaoId { get; set; }

        [Column("endereco_id")]
        public int? EnderecoId { get; set; }

        public Classificacao? Classificacao { get; set; }

        public Endereco? Endereco { get; set; }
    }
}
