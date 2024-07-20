using System;

namespace myFirstApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           SumarNumeros();
        }
        static void SumarNumeros() 
        {
            int num1 = 0;
            int num2 = 0;
            int suma = 0;

            Console.WriteLine("Digite el num 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el num 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            suma = (num1 + num2);

            Console.WriteLine($"El resultado es: {suma}");

            Console.ReadLine();
        }

        static void MultiplicarNumeros() 
        {
            int num1 = 0;
            int num2 = 0;
            int suma = 0;

            Console.WriteLine("Digite el num 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el num 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            suma = (num1 * num2);

            Console.WriteLine($"El resultado es: {suma}");

            Console.ReadLine();

        }

    }
}
