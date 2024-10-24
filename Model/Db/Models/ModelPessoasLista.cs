
namespace controle_vendas_comissoes.Model.Db.Models
{
    public record class ModelPessoasLista
    {
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public string Sobrenome { get; set; } = string.Empty;

        public string Cpf { get; set; } = string.Empty;

        public string Rg { get; set; } = string.Empty;

        public DateTime? DataNascimento { get; set; }

        public int? ClassificacaoId { get; set; }

        public string ClassificacaoDescricao { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }

        public int? EnderecoId { get; set; }

    }
}
