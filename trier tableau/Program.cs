using System;
namespace trier_tableau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[6];
            tab[0] = 11; 
            tab[1] = 1;
            tab[2] = 10;
            tab[3] = 4;
            tab[4] = 7;
            
            Array.Sort(tab);
            int number;
            do
            {
                Console.WriteLine("entrez un nombre");

            } while (!int.TryParse(Console.ReadLine(), out number));
            for (int i = 4; i >= 0; i--)
            {
  
                if (number > tab[i] )
                {
                    
                 for(int j = 5; j > i ; j--)
                    {   
                        
                        tab[j] = tab[j - 1];

                    }
                 tab[i + 1] = number;
                    break;
                }
            }
            for (int i = 0; i < 6; i++)
            {
                Console .WriteLine(tab[i]);
            }

        }
    }
}