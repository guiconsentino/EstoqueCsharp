using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace OopEstoque {
    internal class  Produto {

        public static List<Produto> ProdutosEstq = new List<Produto>();
        private string _nome;
        public int Quantidade { get;private set; }
        public double Preco { get;private set; }

        public Produto() {
        }

        public Produto(string nome, int quantidade, double preco) {
           _nome = nome;
           Quantidade = quantidade;
           Preco = preco;
        }

        public static void valorTotalCadaProduto() {

            foreach (var itens in ProdutosEstq) {
                double valorTotal = itens.Quantidade * itens.Preco;
                Console.WriteLine("o valor total do produto " + itens.Nome + " no estoque é = " + valorTotal);
            }

        }

        public static void produtosNoEstoque() {
            foreach (var itens in ProdutosEstq) {
                Console.WriteLine(itens);
            }

        }
        public static void valorTotalEstoque() {
            double total = 0;

            foreach (var itens in ProdutosEstq) {
                total += itens.Quantidade * itens.Preco;

            }
            Console.WriteLine("valor total do estoque = " + total);
        }

        public string Nome {
            get { return _nome; }
            
            set {
                if (value.Length > 1 && value != null) {
                   _nome = value;
                }
            }
        }
     
        public List<Produto> Produtos {
            get { return ProdutosEstq; }
            set { ProdutosEstq = value; }
        }

        public override string ToString() {
            return "\nNome:" + _nome + "\nQuantidade:" + Quantidade + "\nPreço:R$" +
                Preco.ToString("F2", CultureInfo.InvariantCulture) + " Und";
        }


    }
}


