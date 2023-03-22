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
        public int x, y, speed, size;

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
            
            if (r.Contains(enemy))
            {
                y += speed;
            }
            else
            {
                if (speed < 0)
                {
                    y = r.Y; 
                }
                else
                {
                    y = r.Height + r.Y - size; 
                }

                y += (speed *= -1);
            }
        }
    }
}
