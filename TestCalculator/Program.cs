using System;

namespace TestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Equations myInstance = new Equations();

            Console.WriteLine("Bienvenido a la calculadora de 2 digitos");
            Console.WriteLine("Seleccione 1 para Suma");
            Console.WriteLine("Seleccione 2 para Resta");
            Console.WriteLine("Seleccione 3 para Mulitplicación");
            Console.WriteLine("Seleccione 4 para División");
            Console.WriteLine("");



            int caseSwitch = Int32.Parse(Console.ReadLine());

            switch (caseSwitch)
            {
                case 1:
                    myInstance.Suma();
                    break;
                case 2:
                    myInstance.Resta();
                    break;
                case 3:
                    myInstance.Multiplicacion();
                    break;
                case 4:
                    myInstance.Division();
                    break;
            }
            Console.ReadLine();
        }
    }
}
