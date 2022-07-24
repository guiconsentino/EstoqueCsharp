using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace OopEstoque {
    internal class ProdutoTeste {

        public static void Main(string[] args) {
            
            Produto produto1 = new Produto("Maça", 2, 10);
            Produto produto2 = new Produto("Banana", 1, 30);
            Produto produto3 = new Produto("Uva", 5, 10.22);
            Produto produto4 = new Produto("TicTac", 5, 3.0);

            Produto.ProdutosEstq.Add(produto1);
            Produto.ProdutosEstq.Add(produto2);
            Produto.ProdutosEstq.Add(produto3);
            Produto.ProdutosEstq.Add(produto4);
            

            Produto.valorTotalCadaProduto();

            Produto.valorTotalEstoque();
        
            Produto.produtosNoEstoque();
        }
    }
}
