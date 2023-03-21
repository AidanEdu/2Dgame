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
        int x, y, speed, size;

        public Enemy (int _x, int _y,int _size,int _speed)
        {
            x = _x;
            y = _y;
            size = _size; 
            speed = _speed;
        }

        public void Move(Rectangle r)
        {
            Rectangle enemy = new Rectangle(x, y, size, size);
            
            if (r.IntersectsWith(enemy))
            {
                x += speed;
            }
            else
            {
                x += (speed *= -1); 
            }
        }
    }
}
