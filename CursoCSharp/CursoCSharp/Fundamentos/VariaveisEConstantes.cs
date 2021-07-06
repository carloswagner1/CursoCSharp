using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            //area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + (area+1000));

            //Tipos internos
            bool estaChovendo = true;
            Console.WriteLine("Está Chovendo " +estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " +idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("O saldo de gols é "+ saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário é " + salario);

            int menorValorInt = int.MinValue;//Mais usados dos inteiros!!!
            Console.WriteLine("Menor Inteiro é " + menorValorInt);

            uint populacaaBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira é " + populacaaBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long " + menorValorLong);

            ulong populacaoMundo = 7_600_000_0000;
            Console.WriteLine("População Mundial " + populacaoMundo);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço do Computador " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00; //Mais usado dos reais
            Console.WriteLine("Valor de Mercado da Apple " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre estrelas " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);
            string texto = "Seja bem vindo ao Curso de C#!!";
            Console.WriteLine(texto);
        }
    }
}
