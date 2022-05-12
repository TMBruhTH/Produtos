using ModelProdutosDB.Data;
using ModelProdutosDB.ModelDB;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ProdutoContext _produtoContext;

        public ProdutoRepository(ProdutoContext produtoContext)
        {
            _produtoContext = produtoContext;
        }

        public Task<ProdutosModel> AdicionarProduto(ProdutosModel model)
        {
            throw new NotImplementedException();
        }

        public Task AtualizarProduto(ProdutosModel model)
        {
            throw new NotImplementedException();
        }

        public Task ExcluirProduto(int idProduto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProdutosModel>> PesquisarProdutos()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProdutosModel>> PesquisarProdutos_Filtro(string descricao)
        {
            throw new NotImplementedException();
        }
    }
}
