using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            var nome = "Carlos";
            Console.WriteLine(nome);
            //o compilador reconhece como string por inferência. Tem que declarar o valor
            var idade = 45; //tem que inicializar a variável na propria linha
            Console.WriteLine(idade);

            int a; //tratando-se de variável tipada, pode inicializar depois
            a = 3;
            int b = 2;

            Console.WriteLine(a + b);
        }
    }
}
