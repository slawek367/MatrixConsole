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
        private static readonly object SyncObject = new object();

        static void Main()
        {
            Random rand = new Random();
            Window.ConfigureWindow();

            
            for (int i = 0; i < 49; i++)
            {
                lock (SyncObject) { 
                    Thread thread = new Thread(() => Display.DisplayColumn(new Random(), rand.Next(0,3), Window.xSize, i, Window.minTextLen, Window.maxTextLen));
                    thread.Start();
                }
            }
            
            /*
            Thread thread1 = new Thread(() => Display.DisplayColumn(new Random(), rand.Next(200, 500), Window.xSize, 0, Window.minTextLen, Window.maxTextLen));
            thread1.Start();
            Thread thread2 = new Thread(() => Display.DisplayColumn(new Random(), rand.Next(200, 500), Window.xSize, 1, Window.minTextLen, Window.maxTextLen));
            thread2.Start();
            */
            Console.ReadKey();
        }
    }
}
