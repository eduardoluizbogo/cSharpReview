using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpReview._16___ExceptionBasic
{
    internal class Program
    {
        public static void Main1(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not allowed");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error! " + e.InnerException);
            }
        }
    }
}
