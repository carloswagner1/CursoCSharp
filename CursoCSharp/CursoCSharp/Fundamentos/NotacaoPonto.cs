using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "Olá".ToUpper().Insert(3, " World").Replace("World", "Mundo!!");
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);
            //a partir da notacao ponto é possível acessar funcionalidades

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length); 
            //cuidado ao atribuir alguma funcionalidade a um valor nulo. Dá erro. Colocar "?" que funciona.

        }
           
    }
}
