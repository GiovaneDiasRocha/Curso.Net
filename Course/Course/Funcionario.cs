using System.Collections.Generic;

namespace Course
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(){}

        public Funcionario (int id, string nome, double salario) {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void aumentarSalario(double porcentagem) {
            Salario += Salario * porcentagem / 100;
        }

        public Funcionario buscaFuncionario(List <Funcionario> listaFuncionario, int idAux) {
            foreach (Funcionario item in listaFuncionario)
                    {
                        if (item.Id == idAux)
                        {
                            return item;
                        }
                    }
                    return null;
        }

    }
}