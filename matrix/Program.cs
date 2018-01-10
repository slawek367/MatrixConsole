using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace matrix
{
    class Program
    {
        static void Main()
        {
            Random rand = new Random();
            Window.ConfigureWindow();

            /*
            Console.SetCursorPosition(5, 5);
            Console.Write('a');

            Console.SetCursorPosition(2, 7);
            Console.Write('b');
            */
            int startPos = 0;
            int endPos = 30;

            //Column[] columns = new Column[10];
            //columns[0] = new Column(rand, 0);
            //columns[0].ShowColumn();

            for (int i = 0; i < 149; i++)
            {
                Thread thread = new Thread(() => Display.DisplayColumn(new Random(), 100, Window.xSize, i, Window.minTextLen, Window.maxTextLen));
                thread.Start();
            }
            //Thread thread2 = new Thread(() => Display.DisplayColumn(rand, 100, Window.xSize, 3, Window.minTextLen, Window.maxTextLen));
            //thread2.Start();

            //Display.DisplayColumn(rand, 1000, Window.xSize, 0, Window.minTextLen, Window.maxTextLen);

            /*
            while (true)
            {

            }*/

            Console.ReadKey();
        }
    }
}
