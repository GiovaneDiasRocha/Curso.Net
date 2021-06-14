using System;

namespace Course
{
    public class ExercicioVetorAluguelDeQuarto
    {
        public static void Main(string[] args)
        {
            Console.Write("\nInforme a quantidade de alunos que irão alugar os quartos: ");
            int n = int.Parse(Console.ReadLine()), aux = 0;

            string[] quarto = new string[10];
            Estudante[] estudantes = new Estudante[n];

            Console.WriteLine("\nRegistro de aluguel");

            while (n >= 1)
            {
                Console.WriteLine($"\nRegistro #{aux + 1}:\n");

                Console.Write("N° do quarto que deseja alugar: ");
                int numeroDoQuarto = int.Parse(Console.ReadLine());

                if (quarto[numeroDoQuarto] == null)
                {
                    Console.Write("\nNome: ");
                    string nome = Console.ReadLine();

                    Console.Write("\nEmail: ");
                    string email = Console.ReadLine();

                    estudantes[aux] = new Estudante { Nome = nome, Email = email, NumeroDoQuarto = numeroDoQuarto };
                    quarto[numeroDoQuarto] = "\nOcupado";
                    n--;
                    aux++;
                }
                else
                {
                    Console.WriteLine("\nQuarto ocupado!");
                }


            }
            Console.WriteLine("\nQuartos alugados: \n");
            for (int i = 0; i < estudantes.Length; i++)
            {
                Console.WriteLine($"N° do quarto: {estudantes[i].NumeroDoQuarto}, Nome: {estudantes[i].Nome}, Email: {estudantes[i].Email}\n");
            }
        }
    }
}