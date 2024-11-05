using controle_vendas_comissoes.Controller.Utils;

namespace controle_vendas_comissoes.Model.Db.Models
{
    public record class ModelComissoesProduto
    {
        private decimal valosReal   = 0m;
        private decimal porcentagem = 0m;

        public string ClassificacaoNome { get; set; } = string.Empty;

        public int ClassificacaoId { get; set; }

        public decimal ValosReal
        {
            set
            {
                this.valosReal = value;
            }
            get => Utils.FormataDecimalMonetario(this.valosReal);            
        }

        public decimal Porcentagem
        {
            set
            {
                this.porcentagem = value;
            }
            get => Utils.FormataPorcentagem(this.porcentagem);            
        }
    }
}
