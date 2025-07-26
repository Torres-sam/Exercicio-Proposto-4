using System;
using System.Globalization;
namespace MyApp
{
    internal class ExercicioProposto4
    {
        static void Main(string[] args)
        {
            Console.Write("Id Funcionario: ");
            int funcionarioId = int.Parse(Console.ReadLine());
            Console.Write("Horas Trabalhadas: ");
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            Console.Write("Valor por Hora: ");
            double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salario = horasTrabalhadas * valorPorHora;
            Console.WriteLine($"NUMBER = {funcionarioId}");
            Console.WriteLine($"SALARY = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");



        }
    }
}