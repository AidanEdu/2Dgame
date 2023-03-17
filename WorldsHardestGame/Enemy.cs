using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace WorldsHardestGame
{
    internal class Enemy
    {
        int x, y, speed;

        public Enemy (int _x, int _y, int _speed)
        {
            x = _x;
            y = _y; 
            speed = _speed;
        }

        void move (int y, Rectangle p)
        {
            if (y > p.Location.Y && y < p.Height)
            {
                y += speed; 
            }
            else
            {
                speed *= -1;
                y += speed; 
            }
        }
        
    }
}
