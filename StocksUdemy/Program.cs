using System;
using System.Globalization;

namespace StocksUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
            Produtos novoproduto = new Produtos();

             Console.WriteLine("Digite os dados do produto:");
             Console.Write("Nome: ");
             novoproduto.Nome = Console.ReadLine();

             Console.Write("Preço: ");
             novoproduto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

             Console.Write("Quantidade em Stock: ");
             novoproduto.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

             Console.WriteLine();
             Console.WriteLine("Dados do produto digitado: " + novoproduto);

             Console.WriteLine();
             Console.WriteLine("Digite a quantidade a adicionar ao stock:");
             int qnt = int.Parse (Console.ReadLine());
             novoproduto.AdicionarProdutos(qnt);

             Console.WriteLine("Dados Atualizados: " + novoproduto);

             Console.WriteLine();
             Console.WriteLine("Digite a quantidade a remover ao stock:");
             qnt = int.Parse(Console.ReadLine());
             novoproduto.RemoverProdutos(qnt);

             Console.WriteLine("Dados Atualizados: " + novoproduto); 

     


        }
    }
}