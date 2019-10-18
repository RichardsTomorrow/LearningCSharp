using System;
using System.Collections.Generic;
using System.Text;

namespace ColorBall
{
    class Ball
    {
        public double Radius { get; set; }
        public Color Color { get; set; }
        private int throws = 0;

        public Ball(double radius, Color color)
        {
            Radius = radius;
            Color = color;
        }
        public void Pop()
        {
            Radius = 0;
           // Console.WriteLine($"Ahhh! you popped the {color} ball"); //I wanted this to say the color of the ball but it doesn't
        }
        public void Throw(int throws)
        {
            if (Radius > 0)
            {
                this.throws = this.throws + throws;
            }
            else
            {
                Console.WriteLine($"I am sorry but this ball has been popped and can't be thrown");
            }
        }
        public int GetThrows()
        {
            return throws;
        }

    }
}
