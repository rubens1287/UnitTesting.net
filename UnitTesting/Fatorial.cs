namespace UnitTesting
{
    public class Fatorial
    {
        public int resultadoFatorial(int num)
        {
            int fatorial = 0;
            int n = num;

            if (n < 0)
            {
                Console.Out.WriteLine("Número Inválido");
            } else
            {
                fatorial = 1;
                for (int i = 1; i <= n; i++)
                {
                    fatorial *= i;
                    Console.Out.WriteLine(fatorial);
                }
            }
            return fatorial;
        }
    }
}
