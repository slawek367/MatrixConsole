using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    static class Display
    {
        public static void DisplayColumn(Random rand, int speed, int consoleXLen, int columnXPos, int minTextLen, int maxTextLen)
        {
            while (true)
            {
                Column column = new Column(rand, columnXPos, minTextLen, maxTextLen);

                bool firstLoop = true;

                while (column.charBuffer[0].yPosition<consoleXLen)
                {
                    foreach (var item in column.charBuffer)
                    {
                        if (item.yPosition < consoleXLen)
                        {
                            Console.SetCursorPosition(column.xPos, item.yPosition);
                            item.yPosition++;
                            Console.Write(item.letter);

                            if(firstLoop) {
                                System.Threading.Thread.Sleep(speed);
                            }
                        }
                    }
                    
                    if (!firstLoop)
                    {
                        System.Threading.Thread.Sleep(speed);
                    } else
                    {
                        firstLoop = false;
                    }
                    clearConsoleColumn(consoleXLen, columnXPos);
                }
            }
        }

        public static void clearConsoleColumn(int consoleXLen, int columnXPos)
        {
            for (int i = 0; i < consoleXLen; i++)
            {
                Console.SetCursorPosition(columnXPos, i);
                Console.Write(' ');
            }
        }
    }
}
