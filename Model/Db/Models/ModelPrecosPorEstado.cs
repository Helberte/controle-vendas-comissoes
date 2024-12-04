using controle_vendas_comissoes.Controller.Utils;

namespace controle_vendas_comissoes.Model.Db.Models
{
    public record class ModelPrecosPorEstado
    {
        private decimal precoCusto1 = 0m;
        private decimal precoVenda1 = 0m;
        private decimal precoCusto2 = 0m;
        private decimal precoVenda2 = 0m;

        public int ProdutoId { get; set; }

        public string ProdutoNome { get; set; } = string.Empty;

        public string UnidadePrimariaNome { get; set; } = string.Empty;

        public decimal PrecoCusto1
        {
            set
            {
                this.precoCusto1 = value;
            }
            get => Utils.FormataDecimalMonetario(this.precoCusto1);
        }

        public decimal PrecoVenda1
        {
            set
            {
                this.precoVenda1 = value;
            }
            get => Utils.FormataDecimalMonetario(this.precoVenda1);
        }

        public decimal PrecoCusto2
        {
            set
            {
                this.precoCusto2 = value;
            }
            get => Utils.FormataDecimalMonetario(this.precoCusto2);
        }

        public decimal PrecoVenda2
        {
            set
            {
                this.precoVenda2 = value;
            }
            get => Utils.FormataDecimalMonetario(this.precoVenda2);
        }
    }
}
