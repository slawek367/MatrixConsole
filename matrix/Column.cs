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
        public int bufferSize { get; set; }
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

            SetLighterLetters(rand);
        }

        public void ShowColumn()
        {
            foreach (var item in this.charBuffer)
            {
                Console.Write(item.letter);
            }
            Console.WriteLine();
        }

        public void SetLighterLetters(Random rand)
        {
            for (int i = bufferSize - 1 - rand.Next(1,4); i < bufferSize; i++)
            {
                charBuffer[i].colorLighter = true;
            }
        }

        public void changeRandomLetter(Random rand)
        {
            for (int i = 0; i < 3; i++)
            {
                int index = rand.Next(0, bufferSize - 1);
                int currentPos = charBuffer[index].yPosition;
                bool lighter = charBuffer[index].colorLighter;
                charBuffer[index] = new Letter(currentPos, lighter);
            }
        }
    }
}
