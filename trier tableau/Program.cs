using System;
namespace trier_tableau
{
    public class Program
    {
        public static void AddElement(int[] tab, int number)
        {
            int tmp = 0, tmp2;
            bool flagg = false;
            for (int i = 0; i < tab.Length ; i++)
            {
                if (flagg)
                {
                    tmp2 = tab[i];
                    tab[i] = tmp;
                    tmp = tmp2;
                }
                if (number < tab[i] && !flagg)
                {
                    tmp = tab[i];
                    tab[i] = number;
                    flagg = true;
                }
            }
            if (!flagg)
            {
                tab[tab.Length - 1] = number;
            }
        }
        static void Main(string[] args)
        {
            int[] tab = new int[8];
            tab[0] = 1; 
            tab[1] = 6;
            tab[2] = 8;
            tab[3] = 9;
            tab[4] = 11;
            tab[5] = 13;
            tab[6] = 14;
            int number;
            do
            {
                Console.WriteLine("entrez un nombre");

            } while (!int.TryParse(Console.ReadLine(), out number));

            AddElement(tab, number);
            for (int j = 0; j < 8 ; j++)
            {
                Console .WriteLine ( "N ["  + j + " ] " +tab[j]);
            }

        }
    }
}