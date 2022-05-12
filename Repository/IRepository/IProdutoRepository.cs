using System.Collections.Generic;
using System.Threading.Tasks;
using ModelProdutosDB.ModelDB;

namespace Repository.IRepository
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<ProdutosModel>> PesquisarProdutos();
        Task<IEnumerable<ProdutosModel>> PesquisarProdutos_Filtro(string descricao);
        Task<ProdutosModel> AdicionarProduto(ProdutosModel model);
        Task<ProdutosModel> AtualizarProduto(ProdutosModel model);
        Task<ProdutosModel> ExcluirProduto(int idProduto);
    }
}
