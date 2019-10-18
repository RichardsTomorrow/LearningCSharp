using System;
using System.Collections.Generic;
using System.Text;

namespace asterixMover
{
    class Position
    {
        private int x = 0;
        private int y = 0;

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int SetX(int x)
        {
            return this.x = x;
        }
        public int SetY(int y)
        {
            return this.y = y;
        }
    }
}
