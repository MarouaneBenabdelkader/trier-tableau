using System;
namespace trier_tableau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[10];
            tab[0] = 5; 
            tab[1] = 1;
            tab[2] = 10;
            tab[3] = 4;
            Array.Sort(tab);
            int number;
            int tmp;
            number = Console.Read();
            for (int i = 0; i < tab.Length; i++)
            {
                if(number > tab[i])
                {
                    for (int j = i; j < tab.Length; j++)
                    {
                        tmp = tab[j];

                    }
                    
                }
            }
            for (int i = 0; i < tab.Length; i++)
            {
                Console .WriteLine(tab[i]);
            }

        }
    }
}