using System;
using System.Collections.Generic;

namespace TicTocToe2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            Initiator();

        }

        public static void Initiator()
        {
            SplashScreen();
            GridStateCache();
            PrettyGrid(GridStateCache());
            PrintAnswer("Labas", "labas", "labas");
        }

        public static void SplashScreen() {
            Console.WriteLine("TicTocToe_2.0!");
            Console.WriteLine("With:");
            Console.WriteLine("     (1) Dictionary based grid;");
            Console.WriteLine("     (2) UI based on String interpolation;");
            Console.WriteLine("     (?) What else...?");
            Console.WriteLine();
            Console.WriteLine("Any input to continue...");
            Console.ReadKey();
        }

        public static Dictionary<int, char> GridStateCache()
        {
            var Grid = new Dictionary<int, char>() //¹ ² ³ ⁴ ⁵ ⁶ ⁷ ⁸ ⁹ 
            {
                {0,'¹'},{1,'²'},{2,'³'},
                {3,'⁴'},{4,'⁵'},{5,'⁶'},
                {6,'⁷'},{7,'⁸'},{8,'⁹'},
            };
            return Grid;
        }

        public static void PrettyGrid(Dictionary<int, char> Grid)
        {
            Console.WriteLine($"        {Grid[0]} | {Grid[1]} | {Grid[2]} ");
            Console.WriteLine($"        ———+———+———");
            Console.WriteLine($"        {Grid[3]} | {Grid[4]} | {Grid[5]} ");
            Console.WriteLine($"        ———+———+———");
            Console.WriteLine($"        {Grid[6]} | {Grid[7]} | {Grid[8]} ");
        }

        // Spalvojimo pavizdys:, bet tragiškai atrodys lentelės kodas spalvojant elementus
        // ir grid'ą atskirai
        private static void PrintAnswer(string noun, string verb, string adjective)
        {
            Console.Write("A ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(noun);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" likes to eat a lot. It likes to ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(verb);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" in the ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(adjective);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" looking water.");
            Console.ResetColor();
        }

    }
}

