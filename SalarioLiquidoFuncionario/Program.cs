using System;
using System.Globalization;

namespace SalarioLiquidoFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Funcionario f = new Funcionario();
            
            
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Funcionário: " +f);
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double  porcent = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            f.AumentarSalario(porcent);

            Console.Write("Dados atualizados: " +f);

        }
    }
}
