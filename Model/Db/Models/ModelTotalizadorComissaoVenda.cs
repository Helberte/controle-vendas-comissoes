using controle_vendas_comissoes.Controller.Utils;

namespace controle_vendas_comissoes.Model.Db.Models
{
    public record class ModelTotalizadorComissaoVenda
    {
        private decimal totalComissao = 0m;
        private decimal total         = 0m;

        public int PedidoVendaId { get; set; }

        public string Nome { get; set; } = string.Empty;

        public decimal TotalComissao
        {
            set
            {
                this.totalComissao = value;
            }
            get => Utils.FormataDecimalMonetario(this.totalComissao);
        }

        public decimal Total
        {
            set
            {
                this.total = value;
            }
            get => Utils.FormataDecimalMonetario(this.total);
        }
    }
}
