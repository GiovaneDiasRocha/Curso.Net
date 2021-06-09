using System;
using System.Globalization;
namespace Course

{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício área triângulo 

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.Write("Digite o lado A do triângulo x: ");
            x.a = double.Parse(Console.ReadLine());

            Console.Write("Digite o lado B do triângulo x: ");
            x.b = double.Parse(Console.ReadLine());

            Console.Write("Digite o lado C do triângulo x: ");
            x.c = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Digite o lado A do triângulo y: ");
            y.a = double.Parse(Console.ReadLine());

            Console.Write("Digite o lado B do triângulo y: ");
            y.b = double.Parse(Console.ReadLine());

            Console.Write("Digite o lado C do triângulo y: ");
            y.c = double.Parse(Console.ReadLine());

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("Área do Triângulo X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área do Triângulo Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("A maior área é: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("A maior área é: " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            }


            //Exercício estoque produto
            Produto produtoX;
            produtoX = new Produto();

            Console.WriteLine("Digite os dados do produto:");
            Console.Write("Nome: ");
            produtoX.nomeDoProduto = Console.ReadLine();
            Console.Write("Preço: ");
            produtoX.precoDoProduto = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            produtoX.quantidadeDoProduto = int.Parse(Console.ReadLine());

            Console.WriteLine(produtoX.ToString());
            Console.Write("Digite o número de produtos a serem adicionados ao estoque: ");
            produtoX.adicionarProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine(produtoX.ToString());
            Console.Write("Digite o número de produtos a serem removidos do estoque: ");
            produtoX.removerProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine(produtoX.ToString());

        }
    }
}
