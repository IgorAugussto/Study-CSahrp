using OrientaçãoObjeto;
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto("TV", 500.00, 10);

            produto.Nome = "T";

            Console.WriteLine(produto.Nome);
            Console.WriteLine(produto.Preco);

        }
    }
}
