using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class Absoluto
    {
       public int retornaValorAbsoluto(int valor)
        {
            int res = valor;
            if (valor < 0)
            {
                res = -valor;
            }
            Console.Out.Write(res);
            return res;
        } 
    }
}
