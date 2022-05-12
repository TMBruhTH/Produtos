using Service.IService;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ModelProdutosDB.ModelDB;
using Repository.IRepository;

namespace Service.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        public async Task<ProdutosModel> AdicionarProduto(ProdutosModel model)
        {
            return await _produtoRepository.AdicionarProduto(model);
        }

        public async Task<ProdutosModel> AtualizarProduto(ProdutosModel model)
        {
            return await _produtoRepository.AtualizarProduto(model);
        }

        public async Task<ProdutosModel> ExcluirProduto(int idProduto)
        {
            return await _produtoRepository.ExcluirProduto(idProduto);
        }

        public async Task<IEnumerable<ProdutosModel>> PesquisarProdutos()
        {
            return await _produtoRepository.PesquisarProdutos();
        }

        public async Task<IEnumerable<ProdutosModel>> PesquisarProdutos_Filtro(string descricao)
        {
            return await _produtoRepository.PesquisarProdutos_Filtro(descricao);
        }
    }
}
