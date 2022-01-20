using System;

namespace Home.Work.__5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1-50 arasi ancaq 5-e ya da 3-e bolunen ededleri ile alqoritm yazmaq*/

            for (int i = 0; i < 50; i++)
            {
                if (i % 3 == 0  || i % 5 == 0)

                {Console.WriteLine(i);

                }
            }
            
        }
    }
}
