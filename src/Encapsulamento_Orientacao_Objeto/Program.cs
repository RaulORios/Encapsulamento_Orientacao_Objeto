using System;
using System.Globalization;

namespace Encapsulamento_Orientacao_Objeto
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("TV", 900.00, 10);

            p.SetNome("TV 4K");

            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetQuantidade());

            Console.ReadKey();
        }
    }
}
