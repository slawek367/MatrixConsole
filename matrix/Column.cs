using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace matrix
{
    class Column
    {
        public static int bufferSize { get; set; }
        public Letter[] charBuffer {get;set;}
        public int xPos { get; set; }
        public Column(Random rand, int xPos, int minTextLen, int maxTextLen)
        {
            bufferSize = rand.Next(minTextLen, maxTextLen);
            this.xPos = xPos;

            charBuffer = new Letter[bufferSize];

            for (int i = 0; i < bufferSize; i++)
            {
                charBuffer[i] = new Letter(i);
            }
        }

        public void ShowColumn()
        {
            foreach (var item in this.charBuffer)
            {
                Console.Write(item.letter);
            }
            Console.WriteLine();
        }
    }
}
