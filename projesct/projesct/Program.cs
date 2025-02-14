using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace projesct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public void Divide(double a, double b)
        {
            if(b ==0)
            {
                Console.WriteLine("Ërror:Division by zero is not AllowedValuesAttribute");
            }
            else
            {
                Console.WriteLine(a / b);
            }
        }
    }
}
