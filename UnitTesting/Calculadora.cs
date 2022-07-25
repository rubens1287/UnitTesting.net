using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public static class Calculadora
    {
        public static int Soma(int operador1, int operador2) => operador1 + operador2;
        public static int Subtracao(int operador1, int operador2) => operador1 - operador2;
        public static int Multiplicao(int operador1, int operador2) => operador1 * operador2;
        public static int Divisao(int dividento, int divisor)
        {
            if(divisor == 0)
            {
                Console.Out.Write("Não é possível dividir por zero");
                return 0;
            }

            return dividento / divisor;
        } 
    }
}