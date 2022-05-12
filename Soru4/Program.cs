using System;
//ER3N
namespace Soru4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            
            


            Console.WriteLine();
            Console.WriteLine();


            int sayac = 10;
            for (int c = 1; c <= 100; c++)
            {
                if (c == sayac)
                {
                    sayac = sayac+10;
                    continue;
                }
                Console.WriteLine(c);
            }

        }
    }
}
