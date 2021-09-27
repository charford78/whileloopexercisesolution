using System;

namespace whileloopexercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var cube = 0;
            var nbr = 1;

            while (nbr < 26)
            {
                if (nbr % 2 != 0)
                {
                    cube = nbr * nbr * nbr;
                    Console.WriteLine($"The cube of {nbr} is {cube}.");
                }
                nbr++;
            }
            // This code would also work for this problem and is a little more concise:
            // 
            //var nbr = 1;
            //while(nbr < 26)
            //{
            //    Console.Write($"{nbr * nbr * nbr}");
            //    nbr = nbr + 2;
            //}


        }
    }
}
