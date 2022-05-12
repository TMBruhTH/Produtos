using System.Collections.Generic;
using System.Threading.Tasks;
using ModelProdutosDB.ModelDB;

namespace Service.IService
{
    public interface IProdutoService
    {
        Task<IEnumerable<ProdutosModel>> PesquisarProdutos();
        Task<IEnumerable<ProdutosModel>> PesquisarProdutos_Filtro(string descricao);
        Task<ProdutosModel> AdicionarProduto(ProdutosModel model);
        Task AtualizarProduto(ProdutosModel model);
        Task ExcluirProduto(int idProduto);
    }
}
