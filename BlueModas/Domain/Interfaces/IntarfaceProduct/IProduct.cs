using Domain.Interfaces.Generics;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Entities;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Domain.Interfaces.IntarfaceProduct
{
    public interface IProduct : IGeneric<Produto>
    {
        Task<List<Produto>> ListarProdutosUsuario(string userId);

        Task<List<Produto>> ListarProdutos(Expression<Func<Produto, bool>> exProduto);

        Task<List<Produto>> ListarProdutosCarrinhoUsuario(string userId);

        Task<Produto> ObterProdutoCarrinho(int idProdutoCarrinho);
    }
}
