using System;

namespace InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            string strNum1 = Console.ReadLine();
            string strNum2 = Console.ReadLine();
            int iNum1 = Convert.ToInt32(strNum1);
            int iNum2 = Convert.ToInt32(strNum2);
            Console.WriteLine("{0} + {1} = {2}.", iNum1, iNum2, iNum1 + iNum2);
        }
    }
}
