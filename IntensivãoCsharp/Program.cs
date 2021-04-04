using System;
using System.Globalization;

namespace IntensivãoCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto product = new Produto();
            
            Console.WriteLine("Entre os dados do produto:");
            
            Console.Write("Nome: ");
            product.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            product.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            product.Quantidade = int.Parse(Console.ReadLine());

            Console.Write("Dados do produto: " +product);

            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            
            int qte = int.Parse(Console.ReadLine());
            
            product.AdicionarProdutos(qte);

            Console.WriteLine("Dados atualizados: "+product);


            Console.Write("Digite o número de produtos a ser removido do estoque: ");

             qte = int.Parse(Console.ReadLine());

            product.RemoverProdutos(qte);

            Console.WriteLine("Dados atualizados: " + product);








        }
    }
}