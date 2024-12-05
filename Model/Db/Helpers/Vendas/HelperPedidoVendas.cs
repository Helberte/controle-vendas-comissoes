using controle_vendas_comissoes.Model.Db.Entidades;
using Microsoft.EntityFrameworkCore.Storage;
using RSG;

namespace controle_vendas_comissoes.Model.Db.Helpers.Vendas
{
    public class HelperPedidoVendas
    {
        public static IPromise<PedidoVendaItem> AdicionaProduto(
            PedidoVenda venda, 
            int[] pessoaIds, 
            int produtoId, 
            int estadoId, 
            int ordemTabela,
            decimal quantidadeProduto,
            decimal valorDesconto,
            decimal porcentagemDesconto
            )
        {
            Promise<PedidoVendaItem> promise = new();

            Task.Run(() =>
            { 
                try
                {
                    using AppDbContext context = new();
                    using IDbContextTransaction transaction = context.Database.BeginTransaction();

                    if (    context.PedidoVenda       is not null 
                        &&  context.UnidadesPrimarias is not null)
                    {
                        PedidoVenda?     cabecalhoVenda;
                        PedidoVendaItem? pedidoVendaItem;

                        if (venda.Id <= 0)
                        {
                            AdicionaPedidoVenda(venda, pessoaIds).Then((pedidoVenda) =>
                            {
                                cabecalhoVenda = pedidoVenda;

                            }).Catch((erro) =>
                            {
                                throw new Exception(erro.Message.ToString());
                            });
                        }

                        //Produto? novoProduto = null;
                        //Produto? produtoExiste = context.Produtos.Where(e => e.Nome.Equals(produto.Nome)).FirstOrDefault();

                        //if (produtoExiste is not null)
                        //    if (produtoExiste.Nome.Equals(produto.Nome))
                        //        throw new Exception("Já existe um Produto cadastrado com este Nome.");

                        //UnidadePrimaria? unidadePrimaria = context.UnidadesPrimarias.Where(u => u.Id.Equals(produto.UnidadePrimariaId)).FirstOrDefault();

                        //if (unidadePrimaria is null)
                        //    throw new Exception("A unidade primária informada não existe. Cadastre ela primeiro.");

                        //// insere novo PRODUTO
                        //novoProduto = context.Produtos.Add(produto).Entity;

                        pedidoVendaItem = new PedidoVendaItem();

                        context.SaveChanges();

                        transaction.Commit();

                        promise.Resolve(pedidoVendaItem);
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

        private static IPromise<PedidoVenda> AdicionaPedidoVenda(PedidoVenda pedidoVenda, int[] pessoasIds)
        {
            Promise<PedidoVenda> promise = new();
                       
            try
            {
                using AppDbContext context = new();
                using IDbContextTransaction transaction = context.Database.BeginTransaction();

                if (   context.PedidoVenda       is not null 
                    && context.PessoaPedidoVenda is not null
                    && context.Pessoas           is not null)
                {
                    PedidoVenda? novoPedido = null;
                    
                    if (pessoasIds.Length <= 0)
                        throw new Exception("Nenhuma pessoa fornecida para incluir no pedido.");

                    foreach (int pessoaId in pessoasIds)
                    {
                        Pessoa? pessoa = context.Pessoas.Where(p => p.Id.Equals(pessoaId)).FirstOrDefault();

                        if (pessoa is null)
                            throw new Exception("Pessoa não encontrada no banco. ID: " + pessoaId);
                    }

                    // adiciona o pedido de vendas
                    novoPedido = context.PedidoVenda.Add(pedidoVenda).Entity;
                    context.SaveChanges();

                    PessoaPedidoVenda? pessoaPedido;

                    foreach (int pessoaId in pessoasIds)
                    {
                        pessoaPedido = new()
                        {
                            PedidoVendaId = novoPedido.Id,
                            PessoaId      = pessoaId
                        };

                        context.PessoaPedidoVenda.Add(pessoaPedido);
                        context.SaveChanges();
                    }
                    
                    transaction.Commit();

                    promise.Resolve(novoPedido);
                }
                else
                    promise.Reject(new Exception("Ocorreu um erro ao Inserir um novo Pedido de Vendas"));
            }
            catch (Exception ex)
            {
                promise.Reject(ex);
            }
           
            return promise;
        }

    }
}
