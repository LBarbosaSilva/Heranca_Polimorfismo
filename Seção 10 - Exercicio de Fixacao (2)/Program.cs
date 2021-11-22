using System;
using System.Globalization;
using System.Collections.Generic;
using Seção_10___Exercicio_de_Fixacao__2_.Entities;

namespace Seção_10___Exercicio_de_Fixacao__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler os dados de N contribuintes (N fornecido pelo usuário), os quais 
            podem ser pessoa física ou pessoa jurídica, e depois mostrar o valor do imposto pago por cada um, 
            bem como o total de imposto arrecadado.  */


            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            List<TaxPlayer> list = new List<TaxPlayer>();


            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (c == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, income, health));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberEmployee = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Company(name, income, numberEmployee));
                }
            }

            Console.WriteLine("TAXES PAID: ");
            double sum = 0.0;
            foreach (TaxPlayer tp in list)
            {
                double tax = tp.Tax();
                Console.WriteLine(tp.Name + ": $" + tax.ToString("F2", CultureInfo.InvariantCulture));
                sum += tax;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
