using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual o seu salário? ");
            double salario = double.Parse(Console.ReadLine()); 
            /*imprime com virgula pq sistema é pt-br
            caso queira usar ponto ou virgula, colocar using System.Globalization
            (no lugar de System.Colletions.Generic e 
            depois do Readline(), CultureInfo.InvariantCulture*/

            Console.WriteLine($"{nome} {idade} R${salario}"); 
        }
    }
}
