using System;
using System.Collections.Generic;
using System.Globalization;
namespace Course

{
    class Program
    {
        public static void Main(string[] args)
        {
            int id, n;
            string nome;
            double salario;

            List<Funcionario> listaFuncionarios = new List<Funcionario>();

            Console.Write("Informe o número de funcionários que deseja cadastrar: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("ID do funcionário: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Nome do funcionário: ");
                nome = Console.ReadLine();
                Console.Write("Salário do funcionário: ");
                salario = double.Parse(Console.ReadLine());

                Funcionario func = new Funcionario(id, nome, salario);


                if (listaFuncionarios.Count == 0)
                {
                    listaFuncionarios.Add(func);
                }
                else
                {
                    foreach (Funcionario item in listaFuncionarios)
                    {
                        if (item.Id == id)
                        {
                            Console.WriteLine("ID indisponível!");
                            return;
                        }
                    }
                    listaFuncionarios.Add(func);
                }

            }

            foreach (Funcionario item in listaFuncionarios)
            {
                Console.WriteLine("ID: " + item.Id + ", Nome: " + item.Nome + ", Salário: R$" + item.Salario.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
