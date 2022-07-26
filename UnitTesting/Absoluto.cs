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
