using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; 

namespace WorldsHardestGame
{
    internal class Player
    {
        public int x, y, size, speed;
        public Player(int _x,int _y,int _size,int _speed)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
        }

        public void Move(string direction, List<Rectangle> r)
        {
            bool contatains = false;
            
            Rectangle playerRectangle = new Rectangle(x, y, size, size);

            foreach (Rectangle rect in r)
            {
                if (rect.Contains(playerRectangle) || )
                {
                    contatains = true;
                }
            }


            
            if (direction == "up" && contatains == true)
            {
                y -= speed;
            }
            if (direction == "down" && contatains == true)
            {
                y += speed;
            }
            if (direction == "right" && contatains == true)
            {
                x += speed;
            }
            if (direction == "left" && contatains == true)
            {
                x -= speed;
            }

            
        }
    }
}
