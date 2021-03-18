using System;
using System.Globalization;

namespace Exerc_202.Entities
{
    class Funcionario : IComparable
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(string csvFuncionario)
        {
            string[] vect = csvFuncionario.Split(',');
            Nome = vect[0];
            Salario = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(Object obj)
        {
            if (!(obj is Funcionario))
            {
                throw new ArgumentException("Erro: Argumento escolhido não é um funcionário!");
            }
            Funcionario outro = obj as Funcionario;
            return Nome.CompareTo(outro.Nome);
        }
    }
}
