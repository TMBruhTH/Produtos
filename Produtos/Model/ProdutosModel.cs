using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Produtos.Model
{
    public class ProdutosModel
    {
        [Key]
        public int IdProduto { get; set; }

        [StringLength(150)]
        public string NomeProduto { get; set; }

        public string ImagemProduto { get; set; }

        [StringLength(2000)]
        public string DescProduto { get; set; }

        public int Estoque { get; set; }

        public bool Status { get; set; }

        public decimal Preco { get; set; }
    }
}
