using System.Globalization;


namespace Listas
{
    internal class Funcionario
    {
        public int ID { get; private set; }
        public string Nome { get; private set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            ID = id;
            Nome = nome;
            Salario = salario;
        }
        public void AumentarSalario(double percentual)
        {
            Salario += Salario * percentual / 100.0;
        }

        public override string ToString()
        {
           return "ID: " + ID +
                "\nNome: " + Nome +
                "\nSalario: " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
