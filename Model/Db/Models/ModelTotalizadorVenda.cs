using controle_vendas_comissoes.Controller.Utils;

namespace controle_vendas_comissoes.Model.Db.Models
{
    public record class ModelTotalizadorVenda
    {
        private decimal quantidadeItens             = 0m;
        private decimal totalGeral                  = 0m;
        private decimal porcentagemDescontoProdutos = 0m;
        private decimal valorDescontoProdutos       = 0m;
        private decimal totalComDescontoProdutos    = 0m;

        public int VendaId { get; set; }

        public decimal QuantidadeItens
        {
            set
            {
                this.quantidadeItens = value;
            }
            get => Convert.ToInt32(this.quantidadeItens);
        }

        public decimal TotalGeral
        {
            set
            {
                this.totalGeral = value;
            }
            get => Utils.FormataDecimalMonetario(this.totalGeral);
        }

        public decimal PorcentagemDescontoProdutos
        {
            set
            {
                this.porcentagemDescontoProdutos = value;
            }
            get => Utils.FormataPorcentagem(this.porcentagemDescontoProdutos);
        }

        public decimal ValorDescontoProdutos
        {
            set
            {
                this.valorDescontoProdutos = value;
            }
            get => Utils.FormataDecimalMonetario(this.valorDescontoProdutos);
        }

        public decimal TotalComDescontoProdutos
        {
            set
            {
                this.totalComDescontoProdutos = value;
            }
            get => Utils.FormataDecimalMonetario(this.totalComDescontoProdutos);
        }
    }
}
