using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            DrawScreen();
        }

        public static void DrawScreen()
        {

            ImprimirMais();
            BarraLateral();
            ImprimirMais();
        }

        static void ImprimirMais()
        {
            Console.Write("+");
            for(int i = 0; i <= 30; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
            
        }

        static void BarraLateral()
        {
            for(int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");

                for(int i = 0; i <= 30; i++)
                {   
                    Console.Write(" ");
                }

                Console.Write("|");
                Console.Write("\n");
            }
            
        }
        
        
    }
}