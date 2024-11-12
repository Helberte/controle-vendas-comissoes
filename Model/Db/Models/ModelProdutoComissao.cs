
namespace controle_vendas_comissoes.Model.Db.Models
{
    public record class ModelProdutoComissao
    {
        public decimal ValorReal { get; set; }

        public decimal Porcentagem { get; set; }

        public int ComissaoItemId { get; set; }
    }
}
