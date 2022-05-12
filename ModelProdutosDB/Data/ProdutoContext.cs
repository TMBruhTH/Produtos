using Microsoft.EntityFrameworkCore;
using ModelProdutosDB.ModelDB;

namespace ModelProdutosDB.Data
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
