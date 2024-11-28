using controle_vendas_comissoes.View.Forms.Localidades.Estados;
using controle_vendas_comissoes.View.Forms.Localidades.Cidades;
using controle_vendas_comissoes.View.Forms.Pessoal.Classificacoes;
using controle_vendas_comissoes.View.Forms.Pessoal.Pessoas;
using controle_vendas_comissoes.View.Forms.Produtos.UnidadesDeProdutos;
using controle_vendas_comissoes.View.Forms.Produtos.Produtos;
using controle_vendas_comissoes.View.Forms.GestaoVendas.Comissoes;
using controle_vendas_comissoes.View.Forms.Vendas.PedidoDeVendas;

namespace controle_vendas_comissoes
{
    public static class RedirectMenu
    {
        public static void SendEstados()
        {
            EstadosLista rotina = new();
            rotina.ShowDialog();
        }

        public static void SendCidades()
        {
            CidadesLista rotina = new();
            rotina.ShowDialog();
        }

        public static void SendClassificacoes()
        {
            ClassificacoesLista rotina = new();
            rotina.ShowDialog();
        }

        public static void SendPessoas()
        {
            PessoasLista rotina = new();
            rotina.ShowDialog();
        }

        public static void SendUnidadesPrimarias()
        {
            UnidadesDeProdutos rotina = new();
            rotina.ShowDialog();
        }

        public static void SendProdutos()
        {
            ProdutosLista rotina = new();
            rotina.ShowDialog();
        }

        public static void SendComissoesConfiguracao()
        {
            ComissoesConfiguracao rotina = new();
            rotina.ShowDialog();
        }

        public static void SendPedidoVendas()
        {
            PedidoVendas rotina = new();
            rotina.Show();
        }
    }
}
 