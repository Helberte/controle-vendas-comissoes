using controle_vendas_comissoes.Controller.Utils;

namespace controle_vendas_comissoes.Model.Db.Models
{
    public record class ModelListaItensVenda
    {
        private decimal precoVenda          = 0;
        private decimal total               = 0;
        private decimal porcentagemDesconto = 0;
        private decimal valorDesconto       = 0;
        private decimal totalComDesconto    = 0;

        public int PedidoVendaItemId { get; set; }

        public int ProdutoId { get; set; }

        public string ProdutoNome { get; set; } = string.Empty;

        public decimal Quantidade { get; set; }

        public decimal PrecoVenda
        {
            set
            {
                this.precoVenda = value;
            }
            get => Utils.FormataDecimalMonetario(this.precoVenda);
        }

        public decimal Total
        {
            set
            {
                this.total = value;
            }
            get => Utils.FormataDecimalMonetario(this.total);
        }

        public decimal PorcentagemDesconto
        {
            set
            {
                this.porcentagemDesconto = value;
            }
            get => Utils.FormataPorcentagem(this.porcentagemDesconto);
        }

        public decimal ValorDesconto
        {
            set
            {
                this.valorDesconto = value;
            }
            get => Utils.FormataDecimalMonetario(this.valorDesconto);
        }

        public decimal TotalComDesconto
        {
            set
            {
                this.totalComDesconto = value;
            }
            get => Utils.FormataDecimalMonetario(this.totalComDesconto);
        }

        public DateTime PedidoVendaItemCreatedAt { get; set; }
    }
}
