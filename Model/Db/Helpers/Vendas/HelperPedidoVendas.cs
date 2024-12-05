using controle_vendas_comissoes.Model.Db.Entidades;
using controle_vendas_comissoes.Model.Db.Helpers.Produtos.Produtos;
using controle_vendas_comissoes.Model.Db.Models;
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

                    if (   context.PedidoVenda       is not null 
                        && context.UnidadesPrimarias is not null
                        && context.Produtos          is not null
                        && context.Estados           is not null
                        && context.PedidoVendaItem   is not null)
                    {
                        PedidoVenda      cabecalhoVenda = venda;
                        PedidoVendaItem? pedidoVendaItem;

                        if (cabecalhoVenda.Id <= 0)                                                   
                            cabecalhoVenda = AdicionaPedidoVenda(venda, pessoaIds);

                        Produto? produto = context.Produtos.Where(p => p.Id.Equals(produtoId)).FirstOrDefault();
                        if (produto is null)
                            throw new Exception("Produto não encontrado na base de dados. Produto Id: " + produtoId);

                        Estado? estado = context.Estados.Where(e => e.Id.Equals(estadoId)).FirstOrDefault();
                        if (estado is null)
                            throw new Exception("Estado não encontrado na base de dados. Estado Id: " + estadoId);

                        if (quantidadeProduto <= 0)
                            throw new Exception("A quantidade do produto não pode ser menor ou igual a zero: " + quantidadeProduto);

                        // ------------------------------------------------------------------------------------------------------------------------

                        ModelProdutoPreco preco = HelperProdutos.ObtemPrecoProduto(produtoId, estadoId, ordemTabela);

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
                        }).Entity;

                        context.SaveChanges();

                        //Produto? produtoExiste = context.Produtos.Where(e => e.Nome.Equals(produto.Nome)).FirstOrDefault();

                        //if (produtoExiste is not null)
                        //    if (produtoExiste.Nome.Equals(produto.Nome))
                        //        throw new Exception("Já existe um Produto cadastrado com este Nome.");

                        //UnidadePrimaria? unidadePrimaria = context.UnidadesPrimarias.Where(u => u.Id.Equals(produto.UnidadePrimariaId)).FirstOrDefault();

                        //if (unidadePrimaria is null)
                        //    throw new Exception("A unidade primária informada não existe. Cadastre ela primeiro.");

                        //// insere novo PRODUTO
                        //novoProduto = context.Produtos.Add(produto).Entity;

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

        private static PedidoVenda AdicionaPedidoVenda(PedidoVenda pedidoVenda, int[] pessoasIds)
        {
            using AppDbContext context = new();
            using IDbContextTransaction transaction = context.Database.BeginTransaction();

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

            transaction.Commit();

            return novoPedido;
        }
    }
}
