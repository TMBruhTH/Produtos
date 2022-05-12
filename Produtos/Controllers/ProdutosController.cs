using Microsoft.AspNetCore.Mvc;
using ModelProdutosDB.ModelDB;
using Service.IService;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Produtos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutosController : Controller
    {
        private readonly IProdutoService _produtoService;

        public ProdutosController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet]
        [Route("PesquisarProdutos")]
        public async Task<IEnumerable<ProdutosModel>> PesquisarProdutos()
        {
            return await _produtoService.PesquisarProdutos();
        }

        [HttpGet("{descricao}")]
        [Route("PesquisarProdutos")]
        public async Task<IEnumerable<ProdutosModel>> PesquisarProdutos(string descricao)
        {
            return await _produtoService.PesquisarProdutos_Filtro(descricao);
        }

        [HttpPost]
        [Route("AdicionarProduto")]
        public async Task<ProdutosModel> AdicionarProduto([FromBody] ProdutosModel model)
        {
            return await _produtoService.AdicionarProduto(model);
        }

        [HttpDelete("{id}")]
        [Route("ExcluirProduto")]
        public async Task<ProdutosModel> ExcluirProduto(int id)
        {
            return await _produtoService.ExcluirProduto(id);
        }

        [HttpPut]
        [Route("AtualizarProduto")]
        public async Task<ProdutosModel> AtualizarProduto([FromBody] ProdutosModel model)
        {
            return await _produtoService.AtualizarProduto(model);
        }
    }
}
