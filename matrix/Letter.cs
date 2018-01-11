using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    class Letter
    {
        //Letter class
        public bool colorLighter {get; set;}
        public char letter { get; set; }
        static Random rand = new Random();

        public int yPosition { get; set; }

        public Letter(int yPosition, bool lighter = false)
        {
            this.letter = GetRandomLetter();
            this.colorLighter = lighter;
            this.yPosition = yPosition;
        }

        public static char GetRandomLetter()
        {
            int t = rand.Next(4);

            switch (t)
            {
                case 0: return (char)('0' + rand.Next(10));
                case 1: return (char)('a' + rand.Next(27));
                case 2: return (char)('A' + rand.Next(27));
                case 3: return (char)(rand.Next(32, 255));
            }

            return ' ';
        }
    }
}
