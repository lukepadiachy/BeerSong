using System.Runtime.InteropServices;

namespace BeerSong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Bottles = 99;
            //int Bottle2 = 2;


            //Console.WriteLine(Bottles + " Bottles of beer on the wall," + Bottles + " Bottles of beer");
            //Console.WriteLine("Take one down and pass it around, " + Bottles + " bottles of beer on the wall.");

            while (Bottles > 1)
            {

                Console.WriteLine(Bottles + " Bottles of beer on the wall," + Bottles + " Bottles of beer");
                
                Bottles--;

                Console.WriteLine("Take one down and pass it around, " + Bottles + " bottles of beer on the wall.");
                
               
                Console.WriteLine();
            }
            Console.WriteLine(Bottles + " Bottles of beer on the wall," + Bottles + " Bottles of beer");
            Bottles--;
            Console.WriteLine("Take one down and pass it around, " + Bottles + " bottle of beer on the wall.");
            Console.WriteLine("BUY MORE BEER");

        }
    }
}
