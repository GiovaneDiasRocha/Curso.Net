using System;

namespace Course
{
    public class Aula2VetorProduto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        /*
        Main

        Console.Write("Informe o número de produtos: ");
            int n = int.Parse(Console.ReadLine());

            Aula2VetorProduto[] vetor = new Aula2VetorProduto[n];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Nome do produto {i + 1}: ");
                string nome = Console.ReadLine();
                Console.Write($"Preço do produto {i + 1}: R$");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vetor[i] = new Aula2VetorProduto { Nome = nome, Preco = preco };
            }

            double soma = 0;

            for (int j = 0; j < n; j++)
            {
                soma += vetor[j].Preco;
            }

            double media = soma / n;
            Console.WriteLine($"Média = R${media.ToString("F2", CultureInfo.InvariantCulture)}");

        */
    }
}