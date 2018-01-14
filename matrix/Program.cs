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
            //If program not working good all configuration like window size etc. you could change in Window class
            Random rand = new Random();
            Window.ConfigureWindow();
            Startup();

            for (int i = 0; i < Window.ySize-1; i++)
            {
                //Creating threads which controllong columns
                lock (SyncObject) {
                    Task thread = new Task(() => Display.DisplayColumn(new Random(), rand.Next(Window.maxSpeed, Window.minSpeed), Window.xSize, i, Window.minTextLen, Window.maxTextLen), TaskCreationOptions.LongRunning);
                    thread.Start();
                }
            }

            Console.ReadKey();
        }

        static void Startup()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("-Morpheus: This is a Matrix program!");
            Thread.Sleep(1500);
            Console.WriteLine("-Morpheus: Which pill do you choose?");
            Thread.Sleep(1500);
            Console.Write("-Morpheus: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Red?\t");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Or blue?\n");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("-Neo: Hmm... I will choose red!");
            Thread.Sleep(1200);
            Console.WriteLine("-Morpheus: So... Let's go!");
            Thread.Sleep(1500);
            Console.Clear();
        }
    }
}
