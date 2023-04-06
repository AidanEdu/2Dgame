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
        public int x, y, size, speed, lives;
        public Player(int _x,int _y,int _size,int _speed,int _lives)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
            lives = _lives;
        }

        public void Move(string direction, List<Rectangle> r)
        {
            bool contatains = false;

            for (int i = 0; i < r.Count; i++)
            {
                Rectangle playerRectangle = new Rectangle(x, y, size, size);

                //used recangles to determan the area in which the player can move lots of variation to check. 
                //have sepret if statments due to the index being out of range eg. r[i - 1] would not work in this instence since the index is based on i 
                if (i == 0)
                {
                    //if the rectangle fully contains the player
                    if (r[i].Contains(playerRectangle))
                    {
                        contatains = true;
                    }
                 
                    //if not checks weather the player is out of bounds 
                    else if (r[i].IntersectsWith(playerRectangle) && r[i + 1].IntersectsWith(playerRectangle) == false)
                    {
                        if (x < r[i].X)
                        {
                            x = r[i].X;
                        }
                        if (y < r[i].Y)
                        {
                            y = r[i].Y;
                        }
                        if (x + size > r[i].X + r[i].Width)
                        {
                            x = r[i].X + r[i].Width - size;
                        }
                        if (y + size > r[i].Y + r[i].Height)
                        {
                            y = r[i].Y + r[i].Height - size;
                        }
                    }

                    //if the player does not fit fully within the rectangle and is not fully out of range it will check if the player is crossing into the next movment region
                    //it will also stop the player from cliping out of the movment area even if intercection between both regions and players is true
                    //Works pretty well in the y direction however the x direction was pretty complicated, it doesnt work perfectly but its pretty good. 
                    else if (r[i].IntersectsWith(playerRectangle) && r[i + 1].IntersectsWith(playerRectangle))
                    {
                        contatains = true;

                        //checks if the player X value is greater then either of the x's between the 2 rectangles the player is intercecting
                        //used to avoid clipping, checks which value is closer and places the player there as they are out of bounds 
                        if (Math.Abs(x - r[i].X) > Math.Abs(x - r[i + 1].X))
                        {
                            if (x < r[i].X)
                            {
                                x = r[i].X;
                            }
                        }
                        else
                        {
                            if (x < r[i + 1].X)
                            {
                                x = r[i + 1].X;
                            }
                        }

                        if (Math.Abs(y - r[i].Y) < Math.Abs(y - r[i + 1].Y))
                        {
                            if (y < r[i].Y)
                            {
                                y = r[i].Y;
                            }
                        }
                        else
                        {
                            if (y < r[i + 1].Y)
                            {
                                y = r[i + 1].Y;
                            }
                        }

                        //I got the y values to compare but was having trouble with this one 
                        if (Math.Abs(r[i].X + r[i].Width - x - size) > Math.Abs(r[i + 1].X + r[i + 1].Width - x - size))
                        {
                            if (x + size > r[i].X + r[i].Width)
                            {
                                x = r[i].X + r[i].Width - size;
                            }
                        }
                        else
                        {
                            if (x + size > r[i + 1].X + r[i + 1].Width)
                            {
                                x = r[i + 1].X + r[i + 1].Width - size;
                            }
                        }


                        if (Math.Abs(y - r[i].Y + r[i].Height) < Math.Abs(y - r[i + 1].Y + r[i].Height))
                        {
                            if (y + size > r[i].Y + r[i].Height)
                            {
                                y = r[i].Y + r[i].Height - size;
                            }
                        }
                        else
                        {
                            if (y + size > r[i + 1].Y + r[i + 1].Height)
                            {
                                y = r[i + 1].Y + r[i + 1].Height - size;
                            }
                        }
                    }
                }

                //this is exactly the same as above however it just has a different range in the index so the loops dont bug out
                //code for every other portion of the map
                else if (i != r.Count - 1)
                {
                    if (r[i].Contains(playerRectangle))
                    {
                        contatains = true;
                    }

                    //used if player is intercecting two rectangles, so the player can move freely
                    else if (r[i].IntersectsWith(playerRectangle) && r[i + 1].IntersectsWith(playerRectangle))
                    {
                        contatains = true;

                        //checks if the player y value is greater then either of the y's between the 2 rectangles the player is intercecting
                        if (Math.Abs(x - r[i].X) > Math.Abs(x- r[i + 1].X))
                        {
                            if (x < r[i].X)
                            {
                                x = r[i].X;
                            }
                        }
                        else
                        {
                            if (x < r[i + 1].X)
                            {
                                x = r[i + 1].X;
                            }
                        }


                        if (Math.Abs(y - r[i].Y) < Math.Abs(y - r[i + 1].Y))
                        {
                            if (y < r[i].Y)
                            {
                                y = r[i].Y;
                            }
                        }
                        else
                        {
                            if (y < r[i + 1].Y)
                            {
                                y = r[i + 1].Y;
                            }
                        }

                        //I got the y values to compare but was having trouble with this one 
                        if (Math.Abs(r[i].X + r[i].Width - x - size) > Math.Abs(r[i + 1].X + r[i + 1].Width - x - size))
                        {
                            if (x + size > r[i].X + r[i].Width)
                            {
                                x = r[i].X + r[i].Width - size;
                            }
                        }
                        else
                        {
                            if (x + size > r[i + 1].X + r[i + 1].Width)
                            {
                                x = r[i + 1].X + r[i + 1].Width - size;
                            }
                        }


                        if (Math.Abs(y - r[i].Y + r[i].Height) < Math.Abs(y - r[i + 1].Y + r[i].Height))
                        {
                            if (y + size > r[i].Y + r[i].Height)
                            {
                                y = r[i].Y + r[i].Height - size;
                            }
                        }
                        else
                        {
                            if (y + size > r[i + 1].Y + r[i + 1].Height)
                            {
                                y = r[i + 1].Y + r[i + 1].Height - size;
                            }
                        }
                    }
                    //allows the player to move between rectangles
                    else if (r[i].IntersectsWith(playerRectangle) && r[i - 1].IntersectsWith(playerRectangle))
                    {
                        contatains = true;
                    }

                    else if (r[i].IntersectsWith(playerRectangle) && r[i + 1].IntersectsWith(playerRectangle) == false)
                    {
                        if (x < r[i].X)
                        {
                            x = r[i].X;
                        }
                        if (y < r[i].Y)
                        {
                            y = r[i].Y;
                        }
                        if (x + size > r[i].X + r[i].Width)
                        {
                            x = r[i].X + r[i].Width - size;
                        }
                        if (y + size > r[i].Y + r[i].Height)
                        {
                            y = r[i].Y + r[i].Height - size;
                        }
                    }
                }
               

            }
          

            //exacutes the momvents
            
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

        public void collision(List<Enemy> e, Rectangle r)
        {
            double allowedRadius;
            double actuallRadius;

            foreach (Enemy enemy in e)
            {
                //calculates the distance between the enemy and player allowing varying sizes
                allowedRadius = enemy.size /2+ size/2;

                //calculates the accually center to center distance between the player an enemy e
                actuallRadius = Math.Sqrt(Math.Pow((enemy.x + enemy.size/2) - (x + size/2) , 2) + Math.Pow((enemy.y + enemy.size/2) - (y + size/2), 2));

                //checks if the player and enemy collide
                if (actuallRadius < allowedRadius)
                {
                    lives--;
                    Form1.playSound(Form1.deathSound);
                    x = r.X + r.Width / 2 - size / 2;
                    y = r.Y + r.Height / 2  - size / 2;
                }
            }
        }
    }
}
