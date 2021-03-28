using System;

namespace testsat
{
    class Program
    {
        static void Main(string[] args)
        {
            //ข้อ2เรียบร้อย
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int x = a;
            int y = b;

            while (x < y || x > y)
            {
                if (x < y)
                {
                    x = x + a;
                }
                else 
                {
                   y = y + b;
                }
            }
            if (x == y)
            {
                Console.WriteLine(x);
            }
            else 
            {
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
