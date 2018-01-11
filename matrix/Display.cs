using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    static class Display
    {
        private static readonly object SyncObject = new object();

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
                            lock (SyncObject)
                            {
                                Console.SetCursorPosition(column.xPos, item.yPosition);
                                item.yPosition++;
                                if(item.colorLighter == false)
                                {
                                    Console.Write(item.letter);
                                } else
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write(item.letter);
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                }
                            }

                            if (firstLoop) {
                                System.Threading.Thread.Sleep(speed);
                            }
                        }
                    }

                    column.changeRandomLetter(rand);
                    column.changeRandomLetter(rand);
                    column.changeRandomLetter(rand);
                    column.changeRandomLetter(rand);
                    column.changeRandomLetter(rand);
                    column.changeRandomLetter(rand);

                    if (!firstLoop)
                    {
                        clearField(columnXPos, column.charBuffer[0].yPosition - 2);
                        System.Threading.Thread.Sleep(speed);
                    } else
                    {
                        firstLoop = false;
                    }
                    //clearConsoleColumn(consoleXLen, columnXPos);
                }
                clearField(columnXPos, column.charBuffer[0].yPosition - 1);
            }
        }

        public static void clearConsoleColumn(int consoleXLen, int columnXPos)
        {
            for (int i = 0; i < consoleXLen; i++)
            {
                lock (SyncObject)
                {
                    Console.SetCursorPosition(columnXPos, i);
                    Console.Write(' ');
                }
            }
        }

        public static void clearField(int columnXPos, int columnYPos)
        {
            lock (SyncObject)
            {
                Console.SetCursorPosition(columnXPos, columnYPos);
                Console.Write(' ');
            }
        }
    }
}
