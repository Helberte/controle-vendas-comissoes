
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

        public int? EstadoId { get; set; }

        public string EstadoNome  { get; set; }  = string.Empty;

        public string EstadoUF    { get; set; }  = string.Empty;

        public string CidadeNome  { get; set; }  = string.Empty;

        public string CidadeSigla { get; set; }  = string.Empty;

        public string CEP         { get; set; }  = string.Empty;

        public string Rua         { get; set; }  = string.Empty;

        public string Numero      { get; set; }  = string.Empty;

        public string bairro      { get; set; }  = string.Empty;
    }
}
