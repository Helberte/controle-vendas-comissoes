
namespace controle_vendas_comissoes.Model.Db.Models
{
    public record class ModelProdutosLista
    {
        public int Id { get; set; } 

        public string Nome { get; set; } = string.Empty;

        public string UnidadePrimaria { get; set; } = string.Empty;

        public decimal PrecoCusto1 { get; set; } = 0m;

        public decimal PrecoVenda1 { get; set; } = 0m;

        public decimal PrecoCusto2 { get; set; } = 0m;

        public decimal PrecoVenda2 { get; set; } = 0m;
    }
}
