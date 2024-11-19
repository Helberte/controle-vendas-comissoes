using controle_vendas_comissoes.Controller.Utils;

namespace controle_vendas_comissoes.Model.Db.Models
{
    public record class ModelProdutoPreco
    {
        private decimal precoCusto = 0m;
        private decimal precoVenda = 0m;

        public int TabelaPrecoId { get; set; }

        public int ProdutoTabelaPrecoId { get; set; }

        public int Ordem { get; set; }

        public decimal PrecoCusto
        {
            set
            {
                this.precoCusto = value;
            }
            get => Utils.FormataDecimalMonetario(this.precoCusto);
        }

        public decimal PrecoVenda
        {
            set
            {
                this.precoVenda = value;
            }
            get => Utils.FormataDecimalMonetario(this.precoVenda);
        }
    }
}
