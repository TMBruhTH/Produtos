using Service.IService;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ModelProdutosDB.ModelDB;

namespace Service.Service
{
    public class ProdutoService : IProdutoService
    {
        
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
