using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    static class Window
    {
        public static int ySize = 150;
        public static int xSize = 40;

        public static int minTextLen = 10;
        public static int maxTextLen = 30;


        public static void ConfigureWindow()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WindowLeft = Console.WindowTop = 0;
            //Console.WindowHeight = Console.BufferHeight = Convert.ToInt32(Convert.ToDouble(Console.LargestWindowHeight) * 0.8);
            //Console.WindowWidth = Console.BufferWidth = Convert.ToInt32(Convert.ToDouble(Console.LargestWindowWidth) * 0.8);

            Console.SetWindowSize(ySize, xSize);
            Console.SetCursorPosition(0, 0);
            Console.CursorVisible = false;
        }
    }
}
