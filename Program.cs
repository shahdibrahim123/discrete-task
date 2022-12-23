using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_numbers
{
    internal class Program
    {


        static bool Isperfect(int number )
        {
            int sum = 0;
            for(int i=1;i<number;i++)
            {
                if(number%i==0)
                {
                    sum = sum + i;
                }
            }
            if (sum == number)
            return true;
            return false;
           
        }
        static void Main(string[] args)
        {                    
            Console.WriteLine("Please enter the first number");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");
            for(int i =n1;i<=n2;i++)
            {
                if (Isperfect(i)) Console.WriteLine("{0},", i);
            }
            Console.ReadKey();

        }
    }
}
