using controle_vendas_comissoes.Controller.Utils;

namespace controle_vendas_comissoes.Model.Db.Models
{
    public record class ModelListaItensVenda
    {
        private decimal precoVenda           = 0;
        private decimal total                = 0;
        private decimal porcentagemDesconto  = 0;
        private decimal valorDesconto        = 0;
        private decimal totalComDesconto     = 0;
        private decimal quantidade           = 0;

        private decimal totalComissao        = 0;
        private decimal totalClassificacao01 = 0;
        private decimal totalComissao2       = 0;
        private decimal totalClassificacao02 = 0;
                
        public int PedidoVendaItemId { get; set; }

        public int ProdutoId { get; set; }

        public string ProdutoNome { get; set; } = string.Empty;
                
        public decimal Quantidade
        {
            set
            {
                this.quantidade = value;
            }
            get => Convert.ToInt32(this.quantidade);
        }

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

        public string ClassificacaoNome { get; set; } = string.Empty;

        public decimal TotalComissao
        {
            set
            {
                this.totalComissao = value;
            }
            get => Utils.FormataDecimalMonetario(this.totalComissao);
        }

        public decimal TotalClassificacao01
        {
            set
            {
                this.totalClassificacao01 = value;
            }
            get => Utils.FormataDecimalMonetario(this.totalClassificacao01);
        }
               
        public string? ClassificacaoNome2 { get; set; } = string.Empty;

        public decimal TotalComissao2
        {
            set
            {
                this.totalComissao2 = value;
            }
            get => Utils.FormataDecimalMonetario(this.totalComissao2);
        }

        public decimal TotalClassificacao02
        {
            set
            {
                this.totalClassificacao02 = value;
            }
            get => Utils.FormataDecimalMonetario(this.totalClassificacao02);
        }

        public DateTime PedidoVendaItemCreatedAt { get; set; }
    }
}
