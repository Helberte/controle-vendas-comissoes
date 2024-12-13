﻿using controle_vendas_comissoes.Controller.Utils;

namespace controle_vendas_comissoes.Model.Db.Models
{
    public record class ModelComissoesProduto
    {
        private decimal valorReal   = 0m;
        private decimal porcentagem = 0m;

        public int ClassificacaoId { get; set; }

        public int ComissaoItemId { get; set; }

        public int ComissaoId { get; set; }

        public string ClassificacaoNome { get; set; } = string.Empty;

        public int Ordem { get; set; }
         
        public int ProdutoTabelaPrecoId { get; set; }

        public decimal ValorReal
        {
            set
            {
                this.valorReal = value;
            }
            get => Utils.FormataDecimalMonetario(this.valorReal);            
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
