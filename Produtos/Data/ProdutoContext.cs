using Microsoft.EntityFrameworkCore;
using Produtos.Model;

namespace Produtos.Data
{
    public class ProdutoContext : DbContext
    {
        public DbSet<ProdutosModel> Produtos { get; set; }

        public ProdutoContext(DbContextOptions<ProdutoContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
