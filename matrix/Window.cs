using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    static class Window
    {
        //Window size
        public static int ySize = 100;
        public static int xSize = 40;

        //Min and max text size in each column
        public static int minTextLen = 14;
        public static int maxTextLen = 40;

        //Min and max text scrolling speed (delay in MS between each scroll)
        public static int minSpeed = 250;
        public static int maxSpeed = 30;


        public static void ConfigureWindow()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WindowLeft = Console.WindowTop = 0;

            Console.SetWindowSize(ySize, xSize+1);
            Console.SetCursorPosition(0, 0);
            Console.CursorVisible = false;
        }
    }
}
