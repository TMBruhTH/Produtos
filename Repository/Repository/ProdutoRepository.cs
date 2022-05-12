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

        public async Task<ProdutosModel> AdicionarProduto(ProdutosModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<ProdutosModel> AtualizarProduto(ProdutosModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<ProdutosModel> ExcluirProduto(int idProduto)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProdutosModel>> PesquisarProdutos()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProdutosModel>> PesquisarProdutos_Filtro(string descricao)
        {
            throw new NotImplementedException();
        }
    }
}
