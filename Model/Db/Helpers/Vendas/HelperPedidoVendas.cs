using controle_vendas_comissoes.Model.Db.Entidades;
using controle_vendas_comissoes.Model.Db.Helpers.GestaoVendas.Comissoes;
using controle_vendas_comissoes.Model.Db.Helpers.Produtos.Produtos;
using controle_vendas_comissoes.Model.Db.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using RSG;
using System.Runtime.CompilerServices;

namespace controle_vendas_comissoes.Model.Db.Helpers.Vendas
{
    public class HelperPedidoVendas
    {
        public static IPromise<PedidoVenda> AdicionaProduto(
            PedidoVenda venda, 
            int[] pessoaIds,
            int[] classificacoes,
            int produtoId, 
            int estadoId, 
            int ordemTabela,
            decimal precoVenda,
            decimal quantidadeProduto,
            decimal valorDesconto,
            decimal porcentagemDesconto
            )
        {
            Promise<PedidoVenda> promise = new();

            Task.Run(() =>
            { 
                try
                {
                    using AppDbContext context = new();
                    using IDbContextTransaction transaction = context.Database.BeginTransaction();

                    if (   context.PedidoVenda             is not null 
                        && context.UnidadesPrimarias       is not null
                        && context.Produtos                is not null
                        && context.Estados                 is not null
                        && context.PedidoVendaItem         is not null
                        && context.PedidoVendaItemComissao is not null)
                    {
                        PedidoVenda      cabecalhoVenda = venda;
                        PedidoVendaItem? pedidoVendaItem;

                        if (cabecalhoVenda.Id <= 0)
                            cabecalhoVenda = AdicionaPedidoVenda(context, venda, pessoaIds);
                        else
                        {
                            PedidoVenda? vendaAtualizada = context.PedidoVenda.Where(v => v.Id.Equals(venda.Id)).FirstOrDefault();

                            if (vendaAtualizada is not null)
                                cabecalhoVenda = vendaAtualizada;
                            else
                                throw new Exception("Inconsistência! Pedido de venda não encontrado! Venda Id: " + venda.Id.ToString());
                        }

                        Produto? produto = context.Produtos.Where(p => p.Id.Equals(produtoId)).FirstOrDefault();
                        if (produto is null)
                            throw new Exception("Produto não encontrado na base de dados. Produto Id: " + produtoId);

                        Estado? estado = context.Estados.Where(e => e.Id.Equals(estadoId)).FirstOrDefault();
                        if (estado is null)
                            throw new Exception("Estado não encontrado na base de dados. Estado Id: " + estadoId);

                        if (quantidadeProduto <= 0)
                            throw new Exception("A quantidade do produto não pode ser menor ou igual a zero: " + quantidadeProduto);

                        if (precoVenda <= 0)
                            throw new Exception("É preciso informar um preço de venda para o produto.");

                        // ------------------------------------------------------------------------------------------------------------------------

                        ModelProdutoPreco preco = HelperProdutos.ObtemPrecoProduto(produtoId, estadoId, ordemTabela);

                        // valor do desconto para uma unidade do produto
                        valorDesconto = (porcentagemDesconto / 100) * preco.PrecoVenda;

                        decimal total            = preco.PrecoVenda  * quantidadeProduto;
                        decimal totalDesconto    = quantidadeProduto * valorDesconto;
                        decimal totalComDesconto = total - totalDesconto;

                        pedidoVendaItem = context.PedidoVendaItem.Add(new()
                        {
                            Quantidade          = quantidadeProduto,
                            Total               = total,
                            PorcentagemDesconto = porcentagemDesconto,
                            ValorDesconto       = totalDesconto,
                            TotalComDesconto    = totalComDesconto,
                            PedidoVendaId       = cabecalhoVenda.Id,
                            ProdutoId           = produtoId,
                            PrecoVenda          = precoVenda
                        }).Entity;

                        context.SaveChanges();

                        // ------------------------------------------------------------------------------------------------------------------------

                        // atualiza o cabecalho da venda

                        decimal novoValorDesconto  = 0m;
                        cabecalhoVenda.TotalGeral += total;
                        cabecalhoVenda.Total      += pedidoVendaItem.TotalComDesconto;
                        cabecalhoVenda.UpdatedAt   = DateTime.Now;

                        if (cabecalhoVenda.PorcentagemDesconto > 0)                        
                            novoValorDesconto = (cabecalhoVenda.PorcentagemDesconto / 100) * cabecalhoVenda.Total;
                        
                        cabecalhoVenda.ValorDesconto    = novoValorDesconto;
                        cabecalhoVenda.TotalComDesconto = cabecalhoVenda.Total - novoValorDesconto;

                        context.Entry(cabecalhoVenda).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        context.SaveChanges();

                        // ------------------------------------------------------------------------------------------------------------------------
                        // calculo comissao das pessoas envolvidas

                        List<ModelComissoesProduto>   comissoesProduto = HelperComissoes.ObtemComissoesProduto(context, produtoId, estadoId, classificacoes);
                        List<ModelComissoesProduto>   comissoesOrdem01 = comissoesProduto.FindAll(c => c.Ordem.Equals(1)).ToList();
                        List<PedidoVendaItemComissao> itemsComissao    = [];

                        foreach (ModelComissoesProduto item in comissoesOrdem01)
                        {
                            decimal totalComissao = (item.ValorReal * quantidadeProduto);

                            itemsComissao.Add(new ()
                            {
                                ClassificacaoId   = item.ClassificacaoId,
                                ComissaoItemId    = item.ComissaoItemId,
                                ComissaoId        = item.ComissaoId,
                                PedidoVendaId     = cabecalhoVenda.Id,
                                PedidoVendaItemId = pedidoVendaItem.Id,
                                ValorBase         = totalComDesconto,
                                QuantidadeVendida = quantidadeProduto,
                                ValorComissaoItem = item.ValorReal,
                                TotalComissao     = totalComissao,
                                Total             = totalComDesconto - totalComissao
                            });
                        }

                        if (itemsComissao.Count > 0)
                        {
                            context.PedidoVendaItemComissao.AddRange(itemsComissao);
                            context.SaveChanges();
                        }

                        transaction.Commit();
                        promise.Resolve(cabecalhoVenda);
                    }
                    else
                        promise.Reject(new Exception("Ocorreu um erro ao Inserir um novo produto na venda"));
                }
                catch (Exception ex)
                {
                    promise.Reject(ex);
                }
            });

            return promise;
        }

        private static PedidoVenda AdicionaPedidoVenda(AppDbContext context, PedidoVenda pedidoVenda, int[] pessoasIds)
        {
            if (context.PedidoVenda is null || context.PessoaPedidoVenda is null || context.Pessoas is null)
                throw new Exception("Configuração do banco de dados inválida.");

            PedidoVenda? novoPedido = null;
                
            if (pessoasIds.Length <= 0)
                throw new Exception("Nenhuma pessoa fornecida para incluir no pedido.");

            int[] pessoasExistentes = context.Pessoas.Where(p => pessoasIds.Contains(p.Id)).Select(p => p.Id).ToArray();
            int[] idsFaltantes      = pessoasIds.Except(pessoasExistentes).ToArray();

            if (idsFaltantes.Length > 0)                    
                throw new Exception("As seguintes pessoas não foram encontradas: " + string.Join(", ", idsFaltantes));

            // ------------------------------------------------------------------------------------------------------------

            // adiciona o pedido de vendas
            novoPedido = context.PedidoVenda.Add(pedidoVenda).Entity;
            context.SaveChanges();

            PessoaPedidoVenda[] pessoasPedido = pessoasIds.Select(pessoaId => new PessoaPedidoVenda
            {
                PedidoVendaId = novoPedido.Id,
                PessoaId      = pessoaId
            }).ToArray();

            context.PessoaPedidoVenda.AddRange(pessoasPedido);
            context.SaveChanges();

            return novoPedido;
        }

        public static IPromise<List<ModelListaItensVenda>> ObtemItensVenda(int pedidoVendaId)
        {
            Promise<List<ModelListaItensVenda>> promise = new();

            Task.Run(() =>
            {
                try
                {
                    using AppDbContext context = new();

                    string sql = string.Format(@"
                        SELECT PedidoVendaItemId        = pedido_venda_item.id
                             , ProdutoId                = produto.id
                             , ProdutoNome              = produto.nome
                             , Quantidade               = pedido_venda_item.quantidade
                             , PrecoVenda               = pedido_venda_item.preco_venda
                             , Total                    = pedido_venda_item.total
                             , PorcentagemDesconto      = pedido_venda_item.porcentagem_desconto
                             , ValorDesconto            = pedido_venda_item.valor_desconto
                             , TotalComDesconto         = pedido_venda_item.total_com_desconto
                             , PedidoVendaItemCreatedAt = pedido_venda_item.created_at
                        
                          FROM pedido_venda_item
                        
                         INNER
                          JOIN produto
                            ON produto.deleted_at IS NULL
                           AND produto.id = pedido_venda_item.produto_id
                        
                         WHERE pedido_venda_item.deleted_at IS NULL
                           AND pedido_venda_item.pedido_venda_id = {0}
                        
                         ORDER
                            BY pedido_venda_item.created_at DESC;", pedidoVendaId);

                    List<ModelListaItensVenda>? resultado = context.Database.SqlQuery<ModelListaItensVenda>(FormattableStringFactory.Create(sql)).ToList();

                    promise.Resolve(resultado);
                }
                catch (Exception ex)
                {
                    promise.Reject(ex);
                }
            });

            return promise;
        }

    }
}
