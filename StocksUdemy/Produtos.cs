using System;
using System.Globalization;

namespace StocksUdemy
{
    class Produtos
    {

        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmStock () {
            return Quantidade * Preco;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
            
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
         
        }

        public override string ToString()
        {
            return Nome + ", $ " 
                 + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " 
                 + Quantidade + " unidades, Total: $ " 
                 + ValorTotalEmStock().ToString("F2", CultureInfo.InvariantCulture) ;
        }
    }
}
