using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetrodos
{
    class MetodosEstaticos
    {
        public class CalculadoraEstatica
        {
            //Método de Classe ou Método Estático
            public static int Multiplicar(int a, int b)
            {
                return a * b;
            }

            //Método de Instância
            public int Somar(int a, int b)
            {
                return a + b;
            }
        }
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado: {0}", resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(2,2));


        }
    }
}
