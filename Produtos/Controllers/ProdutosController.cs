using Microsoft.AspNetCore.Mvc;
using Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produtos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutosController : Controller
    {
        private readonly IProdutoService _produtoService;
    }
}
