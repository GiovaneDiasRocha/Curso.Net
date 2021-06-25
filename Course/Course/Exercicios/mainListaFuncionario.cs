namespace Course
{
    public class mainListaFuncionario
    {
        /*
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

            Console.Write("Informe o ID do funcionário que terá o salário aumentado: ");
            int idAux = int.Parse(Console.ReadLine());
            Funcionario funcionario = new Funcionario();
            if (funcionario.buscaFuncionario(listaFuncionarios, idAux) != null)
            {
                Funcionario funcAux = funcionario.buscaFuncionario(listaFuncionarios, idAux);
                Console.Write("Qual a porcentagem do aumento? ");
                double porcentagem = double.Parse(Console.ReadLine());
                funcAux.aumentarSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado!");
            }

            Console.WriteLine("Dados atualizados!");
            foreach (Funcionario item in listaFuncionarios)
            {
                Console.WriteLine("ID: " + item.Id + ", Nome: " + item.Nome + ", Salário: R$" + item.Salario.ToString("F2", CultureInfo.InvariantCulture));
            }
        */
    }
}