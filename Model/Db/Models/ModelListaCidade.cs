namespace controle_vendas_comissoes.Model.Db.Models
{
    public record class ModelListaCidade
    {        
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public string Sigla { get; set; } = string.Empty;

        public string EstadoNome { get; set; } = string.Empty;

        public int EstadoId { get; set; }

    }
}
