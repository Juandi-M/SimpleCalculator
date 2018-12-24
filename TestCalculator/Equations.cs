using System;
using System.IO;

namespace TestCalculator
{
    class Equations
    {
        private double a;
        private double b;
        private double result;
        public void Suma()
        {
            try
            {
                Console.WriteLine("Escriba el valor de a");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Escriba el valor de b");
                b = Convert.ToInt32(Console.ReadLine());

                result = a + b;
                Console.WriteLine("Su resultado es: "+ result);
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro solo usar numeros.");
            }

        }
        public void Resta()
        {
            try
            {
                Console.WriteLine("Escriba el valor de a");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Escriba el valor de b");
                b = Convert.ToInt32(Console.ReadLine());

                result = a - b;
                Console.WriteLine("Su resultado es: " + result);
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro solo usar numeros.");
            }
        }

        public void Multiplicacion()
        {
            try
            {
                Console.WriteLine("Escriba el valor de a");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Escriba el valor de b");
                b = Convert.ToInt32(Console.ReadLine());
                result = a * b;
                Console.WriteLine("Su resultado es: " + result);
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro solo usar numeros.");
            }
        }

        public void Division()
        {
            try
            {
                Console.WriteLine("Escriba el valor de a");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Escriba el valor de b");
                b = Convert.ToInt32(Console.ReadLine());

                result = a / b;
                Console.WriteLine("Su resultado es: " + result);
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro solo usar numeros.");
            }

        }
    }
}
